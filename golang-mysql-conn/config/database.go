package config

import (
	"database/sql"
	"fmt"

	_ "github.com/go-sql-driver/mysql"
)

var DB *sql.DB

func ConnectDB() {
	dsn := "root:@tcp(127.0.0.1:3306)/dbgolang"

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
