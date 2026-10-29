tailwind.config = {
    theme: {
        extend: {
            colors: {
                charcoal: "#252C28",
                charcoal2: "#343D37",
                orange: "#687D6D",
                orangeLight: "#A8B8A8",
                cream: "#F7F8F4",
                soft: "#EEF2EC",
            },
            fontFamily: {
                sans: ["DM Sans", "sans-serif"],
                display: ["Manrope", "sans-serif"],
            },
        },
    },
};

document.addEventListener("DOMContentLoaded", () => {
    const navbar = document.getElementById("navbar");
    const mobileMenuButton = document.getElementById("mobileMenuButton");
    const mobileMenu = document.getElementById("mobileMenu");

    function updateNavbar() {
        const isScrolled = window.scrollY > 40;
        navbar.classList.toggle("bg-[#27312b]/95", isScrolled);
        navbar.classList.toggle("backdrop-blur-xl", isScrolled);
        navbar.classList.toggle("shadow-lg", isScrolled);
    }

    function closeMobileMenu() {
        mobileMenu.classList.add("hidden");
        mobileMenuButton.setAttribute("aria-expanded", "false");
        mobileMenuButton.setAttribute("aria-label", "Open menu");
    }

    updateNavbar();
    window.addEventListener("scroll", updateNavbar, { passive: true });

    mobileMenuButton.addEventListener("click", () => {
        const isOpen = mobileMenuButton.getAttribute("aria-expanded") === "true";
        mobileMenu.classList.toggle("hidden", isOpen);
        mobileMenuButton.setAttribute("aria-expanded", String(!isOpen));
        mobileMenuButton.setAttribute("aria-label", isOpen ? "Open menu" : "Close menu");
    });

    mobileMenu.querySelectorAll("a").forEach((link) => {
        link.addEventListener("click", closeMobileMenu);
    });

    document.addEventListener("keydown", (event) => {
        if (event.key === "Escape") {
            closeMobileMenu();
        }
    });
});