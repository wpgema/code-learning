package models

type UserRequest struct {
	Name           string `json:"name"`
	Prefix         string `json:"prefix"`
	Suffix         string `json:"suffix"`
	BirthDate      string `json:"birth_date"`
	BirthPlace     string `json:"birth_place"`
	Gender         string `json:"gender"`
	Religion       string `json:"religion"`
	MaritialStatus string `json:"maritial_status"`
	PicturePath    string `json:"picture_path"`
}
