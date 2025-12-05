package repositories

import (
	"database/sql"
	"errors"
)

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

func DeleteUser(db *sql.DB, id int) error {
	query := `DELETE FROM users WHERE id = ?`

	result, err := db.Exec(query, id)
	if err != nil {
		return err
	}

	rowsAffected, err := result.RowsAffected()
	if err != nil {
		return err
	}

	if rowsAffected == 0 {
		return errors.New("user not found")
	}

	return nil
}
