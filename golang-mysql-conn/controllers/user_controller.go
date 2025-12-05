package controllers

import (
	"database/sql"
	"net/http"
	"project-go/config"
	"project-go/models"
	"strconv"

	"github.com/gin-gonic/gin"
)

func GetUsers(c *gin.Context) {
	rows, err := config.DB.Query("SELECT * FROM users LIMIT 10")
	if err != nil {
		c.JSON(http.StatusInternalServerError, gin.H{"error": err.Error()})
		return
	}
	defer rows.Close()

	var users []models.User

	for rows.Next() {
		var user models.User
		err := rows.Scan(&user.ID, &user.Name, &user.Prefix, &user.Suffix, &user.BirthDate, &user.BirthPlace, &user.Gender, &user.Religion, &user.MaritialStatus, &user.PicturePath)
		if err != nil {
			c.JSON(http.StatusInternalServerError, gin.H{"error": err.Error()})
			return
		}
		users = append(users, user)
	}

	c.JSON(http.StatusOK, gin.H{
		"status": "success",
		"data":   users,
	})
}

func CreateUser(c *gin.Context) {
	var req models.UserRequest

	if err := c.ShouldBindJSON(&req); err != nil {
		c.JSON(http.StatusBadRequest, gin.H{
			"error": "Invalid request format",
		})
		return
	}

	prefix := sql.NullString{String: req.Prefix, Valid: req.Prefix != ""}
	suffix := sql.NullString{String: req.Suffix, Valid: req.Suffix != ""}

	birthDate := sql.NullString{String: req.BirthDate, Valid: req.BirthDate != ""}
	birthPlace := sql.NullString{String: req.BirthPlace, Valid: req.BirthPlace != ""}

	gender := sql.NullString{String: req.Gender, Valid: req.Gender != ""}

	religion := sql.NullString{String: req.Religion, Valid: req.Religion != ""}

	maritial := sql.NullString{String: req.MaritialStatus, Valid: req.MaritialStatus != ""}

	picture := sql.NullString{String: req.PicturePath, Valid: req.PicturePath != ""}

	result, err := config.DB.Exec(`
		INSERT INTO users 
		(name, prefix, suffix, birth_date, birth_place, gender, religion, maritial_status, picture_path) 
		VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)
	`,
		req.Name, prefix, suffix, birthDate, birthPlace, gender, religion, maritial, picture)

	if err != nil {
		c.JSON(http.StatusInternalServerError, gin.H{
			"error": "Gagal menyimpan data: " + err.Error(),
		})
		return
	}

	id, _ := result.LastInsertId()

	c.JSON(http.StatusOK, gin.H{
		"status":  "success",
		"message": "User berhasil dibuat",
		"id":      id,
	})
}

func UpdateUser(c *gin.Context) {
	// Ambil ID dari URL
	idParam := c.Param("id")
	id, err := strconv.Atoi(idParam)
	if err != nil {
		c.JSON(http.StatusBadRequest, gin.H{"error": "ID tidak valid"})
		return
	}

	// Bind JSON ke struct request
	var req models.UserRequest
	if err := c.ShouldBindJSON(&req); err != nil {
		c.JSON(http.StatusBadRequest, gin.H{"error": "Format JSON tidak valid"})
		return
	}

	// Convert string ke NullString
	prefix := sql.NullString{String: req.Prefix, Valid: req.Prefix != ""}
	suffix := sql.NullString{String: req.Suffix, Valid: req.Suffix != ""}
	birthDate := sql.NullString{String: req.BirthDate, Valid: req.BirthDate != ""}
	birthPlace := sql.NullString{String: req.BirthPlace, Valid: req.BirthPlace != ""}
	gender := sql.NullString{String: req.Gender, Valid: req.Gender != ""}
	religion := sql.NullString{String: req.Religion, Valid: req.Religion != ""}
	maritial := sql.NullString{String: req.MaritialStatus, Valid: req.MaritialStatus != ""}
	picture := sql.NullString{String: req.PicturePath, Valid: req.PicturePath != ""}

	// UPDATE database
	query := `
		UPDATE users SET 
			name = ?, 
			prefix = ?, 
			suffix = ?, 
			birth_date = ?, 
			birth_place = ?, 
			gender = ?, 
			religion = ?, 
			maritial_status = ?, 
			picture_path = ?
		WHERE id = ?
	`

	result, err := config.DB.Exec(query,
		req.Name, prefix, suffix, birthDate, birthPlace, gender, religion, maritial, picture, id)

	if err != nil {
		c.JSON(http.StatusInternalServerError, gin.H{"error": "Gagal update data: " + err.Error()})
		return
	}

	rowsAffected, _ := result.RowsAffected()
	if rowsAffected == 0 {
		c.JSON(http.StatusNotFound, gin.H{"error": "User tidak ditemukan"})
		return
	}

	// Response
	c.JSON(http.StatusOK, gin.H{
		"status":  "success",
		"message": "Data user berhasil diupdate",
		"id":      id,
	})
}

func DeleteUser(db *sql.DB) gin.HandlerFunc {
	return func(c *gin.Context) {
		id := c.Param("id")

		_, err := db.Exec("DELETE FROM users WHERE id = ?", id)
		if err != nil {
			c.JSON(http.StatusInternalServerError, gin.H{"error": err.Error()})
			return
		}

		c.JSON(http.StatusOK, gin.H{
			"message": "User deleted successfully",
		})
	}
}
