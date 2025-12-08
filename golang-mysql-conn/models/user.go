package models

import "time"

type User struct {
	ID             int       `gorm:"primaryKey;autoIncrement" json:"id"`
	Name           string    `gorm:"type:varchar(100);not null" json:"name"`
	Prefix         *string   `gorm:"type:varchar(10)" json:"prefix"`
	Suffix         *string   `gorm:"type:varchar(20)" json:"suffix"`
	BirthDate      time.Time `gorm:"type:date;not null" json:"birth_date"`
	BirthPlace     string    `gorm:"type:varchar(50);not null" json:"birth_place"`
	Gender         string    `gorm:"type:varchar(10);not null" json:"gender"`
	Religion       string    `gorm:"type:varchar(10);not null" json:"religion"`
	MaritialStatus string    `gorm:"type:varchar(20);not null" json:"maritial_status"`
	PicturePath    *string   `gorm:"type:varchar(250)" json:"picture_path"`
}
