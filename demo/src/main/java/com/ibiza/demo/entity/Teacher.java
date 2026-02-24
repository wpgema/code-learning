package com.ibiza.demo.entity;

import java.time.LocalDateTime;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Entity
@Table(name = "teachers")
public class Teacher {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @OneToOne
    @JoinColumn(name = "user_id")
    private User user;

    private String name;

    @Column(name = "prefix_name")
    private String prefixName;

    @Column(name = "suffix_name")
    private String suffixName;

    private String nipy;

    private String email;

    @Column(name = "number_phone")
    private String numberPhone;

    private String address;

    @Column(name = "birth_place")
    private String birthPlace;

    @Column(name = "birth_date")
    private String birthDate;

    private String gender;

    @Column(name = "image_path")
    private String imagePath;

    @Column(name = "created_at")
    private LocalDateTime createdAt;
}