package com.ibiza.demo.controller;

import com.ibiza.demo.entity.Subject;
import com.ibiza.demo.repository.SubjectRepository;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/subjects")
public class SubjectController {

    private final SubjectRepository subjectRepository;

    public SubjectController(SubjectRepository subjectRepository) {
        this.subjectRepository = subjectRepository;
    }

    @GetMapping
    public List<Subject> getAll() {
        return subjectRepository.findAll();
    }

    @PostMapping
    public Subject create(@RequestBody Subject subject) {
        return subjectRepository.save(subject);
    }
}