package config

import (
	"database/sql"
	"fmt"
	"os"

	_ "github.com/go-sql-driver/mysql"
	"github.com/joho/godotenv"
)

var DB *sql.DB

func ConnectDB() {
	// Muat file .env jika ada; jika tidak ada, lanjutkan menggunakan env system
	_ = godotenv.Load()

	// Ambil env, jika kosong gunakan default
	user := os.Getenv("DB_USER")
	if user == "" {
		user = "root" // default user
	}

	pass := os.Getenv("DB_PASS") // default kosong
	host := os.Getenv("DB_HOST")
	if host == "" {
		host = "127.0.0.1"
	}

	port := os.Getenv("DB_PORT")
	if port == "" {
		port = "3306"
	}

	name := os.Getenv("DB_NAME")
	if name == "" {
		name = "dbgolang" // default nama database
	}

	dsn := fmt.Sprintf("%s:%s@tcp(%s:%s)/%s?parseTime=true", user, pass, host, port, name)

	database, err := sql.Open("mysql", dsn)
	if err != nil {
		panic("Gagal membuka koneksi database: " + err.Error())
	}

	err = database.Ping()
	if err != nil {
		panic("Tidak bisa konek ke database: " + err.Error())
	}

	fmt.Println("Database Connected!")
	DB = database
}
