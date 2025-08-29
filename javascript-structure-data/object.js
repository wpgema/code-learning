const obj = {
    name : "gema",
    age : 20,
    sayName: function(pesan){
        console.log(`${pesan} ${this.name}`);
    }
}

console.log(obj);

obj.hobby = "coding"

console.log(obj["hobby"]);

console.log(obj);

obj.sayName("halo");

delete obj.hobby

console.log(obj.hobby);

function Mahasiswa(nama, alamat, ttl){
    this.nama = nama,
    this.alamat = alamat,
    this.ttl = ttl,
    this.sayHello = () => {
        console.log(`halo nama saya ${this.nama}, saya beralamat di ${this.alamat} dan saya lahir pada ${thi.ttl}`)
    }
}

const gema = new Mahasiswa("maulana", "jl m boya", "04-maret-2003");