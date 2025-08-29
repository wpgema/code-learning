// translate bahasa
import { indoLang, h1IndoLang, h3IndoLang, titleAboutIDN, h4IndoLang, aIndoLang } from "./langIDN.js";
import { engLang, h1EngLang, h3EngLang, titleAboutENG, h4EngLang, aEngLang } from "./langENG.js";

const paragraf = Array.from(document.querySelectorAll("p"));
const h1 = Array.from(document.querySelectorAll("h1"));
const titleAboutS = Array.from(document.querySelectorAll(".title-about"));
const h4 = Array.from(document.querySelectorAll("h4"));
const h3 = Array.from(document.querySelectorAll("h3"));
const a = Array.from(document.querySelectorAll("a"));


class translate{
    
}

export const translateToIndonesia = () =>{
    for(let i = 0; i < indoLang.length; i++){
        paragraf[i].innerText = indoLang[i]
    }

    for(let i = 0; i < h1IndoLang.length; i++){
        h1[i].innerText = h1IndoLang[i]
    }

    for(let i = 0; i < h3IndoLang.length; i++){
        h3[i].innerText = h3IndoLang[i]
    }

    for(let i = 0; i < titleAboutIDN.length; i++){
        titleAboutS[i].innerText = titleAboutIDN[i]
    }

    for(let i = 0; i < h4IndoLang.length; i++){
        h4[i].innerText = h4IndoLang[i]
    }

    for(let i = 0; i < aIndoLang.length; i++){
        a[i].innerText = aIndoLang[i]
    }
}

export const translateToEngland = () => {
    for(let i = 0; i < engLang.length; i++){
        paragraf[i].innerText = engLang[i]
    }

    for(let i = 0; i < h1EngLang.length; i++){
        h1[i].innerText = h1EngLang[i]
    }

    for(let i = 0; i < h3EngLang.length; i++){
        h3[i].innerText = h3EngLang[i]
    }

    for(let i = 0; i < titleAboutENG.length; i++){
        titleAboutS[i].innerText = titleAboutENG[i]
    }

    for(let i = 0; i < h4EngLang.length; i++){
        h4[i].innerText = h4EngLang[i]
    }

    for(let i = 0; i < aEngLang.length; i++){
        a[i].innerText = aEngLang[i]
    }
}