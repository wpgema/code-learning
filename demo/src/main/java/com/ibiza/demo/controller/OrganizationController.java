package com.ibiza.demo.controller;

import com.ibiza.demo.entity.Organization;
import com.ibiza.demo.repository.OrganizationRepository;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@CrossOrigin(origins = "http://localhost:5173")
@RestController
@RequestMapping("/organizations")
public class OrganizationController {
    private final OrganizationRepository organizationRepository;

    public OrganizationController(OrganizationRepository organizationRepository) {
        this.organizationRepository = organizationRepository;
    }

    @GetMapping 
    public List<Organization> getAll() {
        return organizationRepository.findAll();
    }

    @GetMapping("/{id}")
    public Organization getById(@PathVariable Long id) {
        return organizationRepository.findById(id).orElseThrow(() -> new RuntimeException("Organization not found with id " + id));
    }

    @GetMapping("/search")
    public List<Organization> getByName(@RequestParam String name) {
        return organizationRepository.findByNameContainingIgnoreCase(name);
    }

    @PutMapping("/{id}")
    public ResponseEntity<Organization> update(
        @PathVariable Long id,
        @RequestBody Organization updatedOrganization) {

        return organizationRepository.findById(id)
                .map(existing -> {
                    existing.setName(updatedOrganization.getName());
                    existing.setLevel(updatedOrganization.getLevel());
                    existing.setSkNumber(updatedOrganization.getSkNumber());
                    existing.setChairman(updatedOrganization.getChairman());
                    existing.setAddress(updatedOrganization.getAddress());
                    existing.setPhone(updatedOrganization.getPhone());
                    existing.setEmail(updatedOrganization.getEmail());
                    existing.setWebsite(updatedOrganization.getWebsite());
                    existing.setLogoPath(updatedOrganization.getLogoPath());

                    Organization saved = organizationRepository.save(existing);
                    return ResponseEntity.ok(saved);
                })
                .orElse(ResponseEntity.notFound().build());
    }

    @PostMapping
    public Organization create(@RequestBody Organization organization) {
        return organizationRepository.save(organization);
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<Void> delete(@PathVariable Long id) {

        if (!organizationRepository.existsById(id)) {
            return ResponseEntity.notFound().build();
        }

        organizationRepository.deleteById(id);
        return ResponseEntity.noContent().build(); // 204 No Content
    }
}
