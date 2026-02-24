package com.ibiza.demo.controller;

import com.ibiza.demo.entity.Admin;
import com.ibiza.demo.repository.AdminRepository;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/admins")
public class AdminController {

    private final AdminRepository adminRepository;

    public AdminController(AdminRepository adminRepository) {
        this.adminRepository = adminRepository;
    }

    @GetMapping
    public List<Admin> getAll() {
        return adminRepository.findAll();
    }

    @PostMapping
    public Admin create(@RequestBody Admin admin) {
        return adminRepository.save(admin);
    }
}