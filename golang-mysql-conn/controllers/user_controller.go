package controllers

import (
	"fmt"
	"net/http"
	"project-go/config"
	"project-go/models"
	"strconv"
	"strings"
	"time"

	"github.com/gin-gonic/gin"
)

func GetUsers(c *gin.Context) {
	page, _ := strconv.Atoi(c.DefaultQuery("page", "1"))
	limit, _ := strconv.Atoi(c.DefaultQuery("limit", "10"))
	if page < 1 {
		page = 1
	}
	if limit < 1 {
		limit = 10
	}
	offset := (page - 1) * limit

	sortBy := strings.ToLower(c.DefaultQuery("sort_by", "id"))
	sortOrder := strings.ToUpper(c.DefaultQuery("sort_order", "ASC"))

	allowedSortBy := map[string]bool{
		"id":   true,
		"name": true,
	}

	if !allowedSortBy[sortBy] {
		sortBy = "id"
	}

	if sortOrder != "ASC" && sortOrder != "DESC" {
		sortOrder = "ASC"
	}

	order := fmt.Sprintf("%s %s", sortBy, sortOrder)

	var users []models.User
	result := config.DB.Order(order).Limit(limit).Offset(offset).Find(&users)
	if result.Error != nil {
		c.JSON(http.StatusInternalServerError, gin.H{"error": result.Error.Error()})
		return
	}

	c.JSON(http.StatusOK, gin.H{
		"page":       page,
		"limit":      limit,
		"sort_by":    sortBy,
		"sort_order": strings.ToLower(sortOrder),
		"data":       users,
	})
}

func CreateUser(c *gin.Context) {
	var req models.UserRequest

	if err := c.ShouldBindJSON(&req); err != nil {
		c.JSON(http.StatusBadRequest, gin.H{"error": "Invalid request format"})
		return
	}

	bd, err := time.Parse("2006-01-02", req.BirthDate)
	if err != nil {
		c.JSON(http.StatusBadRequest, gin.H{"error": "Invalid birth_date format, expect YYYY-MM-DD"})
		return
	}

	var prefix *string
	if req.Prefix != "" {
		prefix = &req.Prefix
	}
	var suffix *string
	if req.Suffix != "" {
		suffix = &req.Suffix
	}
	var picture *string
	if req.PicturePath != "" {
		picture = &req.PicturePath
	}

	user := models.User{
		Name:           req.Name,
		Prefix:         prefix,
		Suffix:         suffix,
		BirthDate:      bd,
		BirthPlace:     req.BirthPlace,
		Gender:         req.Gender,
		Religion:       req.Religion,
		MaritialStatus: req.MaritialStatus,
		PicturePath:    picture,
	}

	if err := config.DB.Create(&user).Error; err != nil {
		c.JSON(http.StatusInternalServerError, gin.H{"error": "Gagal menyimpan data: " + err.Error()})
		return
	}

	c.JSON(http.StatusOK, gin.H{"status": "success", "message": "User berhasil dibuat", "id": user.ID})
}

func UpdateUser(c *gin.Context) {
	idParam := c.Param("id")
	id, err := strconv.Atoi(idParam)
	if err != nil {
		c.JSON(http.StatusBadRequest, gin.H{"error": "ID tidak valid"})
		return
	}

	var req models.UserRequest
	if err := c.ShouldBindJSON(&req); err != nil {
		c.JSON(http.StatusBadRequest, gin.H{"error": "Format JSON tidak valid"})
		return
	}

	var user models.User
	if err := config.DB.First(&user, id).Error; err != nil {
		c.JSON(http.StatusNotFound, gin.H{"error": "User tidak ditemukan"})
		return
	}

	if req.Name != "" {
		user.Name = req.Name
	}
	if req.Prefix != "" {
		user.Prefix = &req.Prefix
	} else {
		user.Prefix = nil
	}
	if req.Suffix != "" {
		user.Suffix = &req.Suffix
	} else {
		user.Suffix = nil
	}
	if req.BirthDate != "" {
		bd, err := time.Parse("2006-01-02", req.BirthDate)
		if err == nil {
			user.BirthDate = bd
		}
	}
	if req.BirthPlace != "" {
		user.BirthPlace = req.BirthPlace
	}
	if req.Gender != "" {
		user.Gender = req.Gender
	}
	if req.Religion != "" {
		user.Religion = req.Religion
	}
	if req.MaritialStatus != "" {
		user.MaritialStatus = req.MaritialStatus
	}
	if req.PicturePath != "" {
		user.PicturePath = &req.PicturePath
	} else {
		user.PicturePath = nil
	}

	if err := config.DB.Save(&user).Error; err != nil {
		c.JSON(http.StatusInternalServerError, gin.H{"error": "Gagal update data: " + err.Error()})
		return
	}

	c.JSON(http.StatusOK, gin.H{"status": "success", "message": "Data user berhasil diupdate", "id": user.ID})
}

func DeleteUser(c *gin.Context) {
	id := c.Param("id")
	result := config.DB.Delete(&models.User{}, id)
	if result.Error != nil {
		c.JSON(http.StatusInternalServerError, gin.H{"error": result.Error.Error()})
		return
	}
	if result.RowsAffected == 0 {
		c.JSON(http.StatusNotFound, gin.H{"error": "User tidak ditemukan"})
		return
	}

	c.JSON(http.StatusOK, gin.H{"message": "User deleted successfully"})
}
