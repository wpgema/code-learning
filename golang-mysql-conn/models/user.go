package models

import "database/sql"

type User struct {
	ID             int
	Name           string
	Prefix         sql.NullString
	Suffix         sql.NullString
	BirthDate      sql.NullString
	BirthPlace     sql.NullString
	Gender         sql.NullString
	Religion       sql.NullString
	MaritialStatus sql.NullString
	PicturePath    sql.NullString
}
