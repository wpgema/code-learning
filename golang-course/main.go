package main

import (
	"encoding/json"
	"fmt"
	"log"
	"os"
	"project-go/helper"
)

type User struct {
	ID    int    `json:"id"`
	Name  string `json:"name"`
	Email string `json:"email"`
}

type ApiResponse struct {
	Status string `json:"status"`
	Data   []User `json:"data"`
}

func main() {
	umur := helper.Add(20, 2)
	nama := "Gema Maulana"
	fmt.Println("Hallo, " + nama + " Apakah Umur kamu " + fmt.Sprint(umur) + " Tahun?")

	jsonData, err := os.ReadFile("api/users.json")
	if err != nil {
		log.Fatalf("Gagal membaca file JSON: %v", err)
	}

	var response ApiResponse
	err = json.Unmarshal(jsonData, &response)
	if err != nil {
		log.Fatalf("Gagal parsing JSON: %v", err)
	}

	fmt.Println("Status API:", response.Status)
	fmt.Println("Daftar User:")
	for _, user := range response.Data {
		fmt.Printf("ID: %d | Nama: %s | Email: %s\n",
			user.ID, user.Name, user.Email)
	}
}
