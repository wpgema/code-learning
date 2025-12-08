package config

import (
	"fmt"
	"os"

	"github.com/joho/godotenv"
	"gorm.io/driver/mysql"
	"gorm.io/gorm"
)

var DB *gorm.DB

func ConnectDB() {
	_ = godotenv.Load()

	user := os.Getenv("DB_USER")
	if user == "" {
		user = "root"
	}

	pass := os.Getenv("DB_PASS")
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
		name = "dbgolang"
	}

	dsn := fmt.Sprintf("%s:%s@tcp(%s:%s)/%s?parseTime=true", user, pass, host, port, name)

	db, err := gorm.Open(mysql.Open(dsn), &gorm.Config{})
	if err != nil {
		panic("Gagal membuka koneksi database (GORM): " + err.Error())
	}

	fmt.Println("Database Connected (GORM)!")
	DB = db
}
