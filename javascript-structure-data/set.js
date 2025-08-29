const ama = new Set([1, 2, 3,"gema", true, 1]);

ama.add(5);
ama.add(5);
console.log(ama.has(3));

for(item of ama){
    console.log(item);
}

ama.delete(3);
console.log(ama.has(3));

for(item of ama){
    console.log(item);
}

ama.forEach(a => console.log(a));

const set = ([true, false, 'maulana', 'gema', 1, 30])