// ================== KONFIGURASI ==================
const spreadsheetId = 'Link your spreadsheet'
const dataOrderSheetName = 'Data Order'
const logSheetName = 'Log'

const botHandle = 'Your username bot'
const botToken  = 'Your token'

const appsScriptUrl = 'Your app script'
const telegramApiUrl = `https://api.telegram.org/bot${botToken}`


// ================== LOG ==================
function log(msg = '') {
  const sheet = SpreadsheetApp.openById(spreadsheetId).getSheetByName(logSheetName)
  sheet.appendRow([new Date(), msg])
}


// ================== FORMAT TANGGAL ==================
function formatDate(date) {
  const month = ['Jan','Feb','Mar','Apr','Mei','Jun','Jul','Ags','Sep','Okt','Nov','Des']
  return `${date.getDate()} ${month[date.getMonth()]} ${date.getFullYear()}`
}

function getStatusIcon(status) {
  const icon = {
    'Sedang dikemas': '📦',
    'Paket telah diambil kurir': '🚚',
    'Dalam perjalanan': '🛣️',
    'Sampai kota tujuan': '🏙️',
    'Dalam pengantaran': '🚛',
    'Pesanan diterima': '📬',
    'Selesai': '✅'
  }

  return icon[status] || '📌'
}


// ================== TELEGRAM ==================
function sendTelegramMessage(chatId, replyToMessageId, text) {
  const url = `${telegramApiUrl}/sendMessage`

  const payload = {
    chat_id: chatId,
    text: text,
    parse_mode: 'HTML',
    disable_web_page_preview: true
  }

  if (replyToMessageId) payload.reply_to_message_id = replyToMessageId

  UrlFetchApp.fetch(url, {
    method: 'post',
    contentType: 'application/json',
    payload: JSON.stringify(payload)
  })
}


// ================== PARSE INPUT ==================
function parseMessage(text = '') {
  const lines = text.split('\n')

  let data = {
    nama: '',
    kodeBarang: '',
    alamat: '',
    resi: ''
  }

  lines.forEach(line => {
    const l = line.toLowerCase()

    if (l.includes('nama:')) data.nama = line.split(':')[1]?.trim()
    if (l.includes('kode barang:')) data.kodeBarang = line.split(':')[1]?.trim()
    if (l.includes('alamat:')) data.alamat = line.split(':')[1]?.trim()
    if (l.includes('resi:')) data.resi = line.split(':')[1]?.trim()
  })

  if (!data.nama && !data.kodeBarang && !data.alamat && !data.resi) return null

  return data
}


// ================== INPUT ORDER ==================
function inputDataOrder(data) {
  try {
    const sheet = SpreadsheetApp.openById(spreadsheetId).getSheetByName(dataOrderSheetName)

    const rowNumber = sheet.getLastRow()
    const idOrder = `ORD-${rowNumber}`

    const statusAwal = 'Sedang dikemas'

    sheet.appendRow([
      rowNumber,
      idOrder,
      new Date(),
      data.nama,
      data.kodeBarang,
      data.alamat,
      data.resi,
      statusAwal,
      data.chatId
    ])

    // ✅ SIMPAN HISTORY AWAL
    saveHistory({
      idOrder,
      resi: data.resi,
      status: statusAwal,
      chatId: data.chatId
    })

    return idOrder

  } catch (err) {
    log(err.toString())
    return false
  }
}

function saveHistory(data) {
  const sheet = SpreadsheetApp.openById(spreadsheetId)
    .getSheetByName('History Status')

  sheet.appendRow([
    new Date(),
    data.idOrder,
    data.resi,
    data.status,
    data.chatId
  ])
}

function cekResi(resi) {
  if (!resi) return 'Format resi tidak valid.'

  const sheet = SpreadsheetApp.openById(spreadsheetId).getSheetByName(dataOrderSheetName)
  const lastRow = sheet.getLastRow()

  if (lastRow < 2) return 'Data kosong.'

  const data = sheet.getRange(2, 1, lastRow - 1, 9).getValues()

  const found = data.find(r =>
    r[6]?.toString().toLowerCase() === resi.toLowerCase()
  )

  if (!found) return `Resi <b>${resi}</b> tidak ditemukan.`

  // ambil history
  const historyText = getHistory(resi)

return `📦 <b>TRACKING RESI</b>

🔎 Resi: <b>${resi}</b>
🆔 ID Order: <b>${found[1]}</b>
📅 Tanggal: ${formatDate(new Date(found[2]))}

👤 Nama: ${found[3]}
📦 Barang: ${found[4]}

📍 <b>Status Saat Ini</b>
${getStatusIcon(found[7])} <b>${found[7]}</b>

━━━━━━━━━━━━━━━
${historyText}`
}

function getHistory(resi) {
  const sheet = SpreadsheetApp.openById(spreadsheetId)
    .getSheetByName('History Status')

  const lastRow = sheet.getLastRow()
  if (lastRow < 2) return 'Belum ada history.'

  const data = sheet.getRange(2, 1, lastRow - 1, 5).getValues()

  const filtered = data.filter(r =>
    r[2]?.toString().toLowerCase() === resi.toLowerCase()
  )

  if (filtered.length === 0) {
    return 'Belum ada history untuk resi ini.'
  }

  filtered.reverse()

  let result = `<b>📜 History Pengiriman</b>\n\n`

  filtered.forEach(r => {
    result += `${getStatusIcon(r[3])} ${formatDate(new Date(r[0]))}\n<b>${r[3]}</b>\n\n`
  })

  return result
}

// ================== WEBHOOK ==================
function doPost(e) {
  try {
    const msg = JSON.parse(e.postData.contents)

    const chatId = msg.message.chat.id
    const text = msg.message.text.replace(botHandle, '').trim()
    const messageId = msg.message.message_id

    let reply = ''

    if (text === '/start') {
      reply = 'Bot aktif ✅'

    } else if (text.startsWith('/input')) {
      const parsed = parseMessage(text)

      if (!parsed) {
        reply = 'Format salah.'
      } else {
        parsed.chatId = chatId
        const id = inputDataOrder(parsed)
        reply = id ? `Data tersimpan: <b>${id}</b>` : 'Gagal simpan data'
      }

    } else if (text.startsWith('/resi')) {
      const resi = text.split(' ')[1]
      reply = cekResi(resi)

    } else if (text === '/format') {
      reply = `Format:

<pre>/input
Nama:
Kode Barang:
Alamat:
Resi:</pre>

Cek:
<pre>/resi NOMOR</pre>`

    } else {
      reply = 'Perintah tidak dikenal. /format'
    }

    sendTelegramMessage(chatId, messageId, reply)

  } catch (err) {
    log(err.toString())
  }
}


// ================== SET WEBHOOK ==================
function setWebhook() {
  const url = `${telegramApiUrl}/setWebhook?url=${appsScriptUrl}`
  Logger.log(UrlFetchApp.fetch(url).getContentText())
}

function handleUpdateDeliveryStatus(e) {
  const sheet = e.source.getActiveSheet()
  const range = e.range

  if (sheet.getName() !== dataOrderSheetName || range.getColumn() !== 8) return

  const row = range.getRow()
  if (row < 2) return

  const data = sheet.getRange(row, 1, 1, 9).getValues()[0]

  const idOrder = data[1]
  const tanggal = data[2]
  const nama = data[3]
  const kodeBarang = data[4]
  const alamat = data[5]
  const resi = data[6]
  const status = data[7]
  const chatId = data[8]

  // ✅ INI YANG KAMU KURANG
  saveHistory({
    idOrder,
    resi,
    status,
    chatId
  })

  const message = `Update Resi <b>${resi}</b>

ID Order: ${idOrder}
Tanggal: ${formatDate(new Date(tanggal))}
Nama: ${nama}
Kode Barang: ${kodeBarang}
Alamat: ${alamat}
Status: <b>${status}</b>`

  sendTelegramMessage(chatId, null, message)
}