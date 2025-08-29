// QUEUE OVERVIEW
// struktur data queue ini berprinsip First In First Out (FIFO)
// dimana elemen yang pertama masuk adalah elemen yang pertama keluar

class Que{
    constructor(){
        this.items = [];
    }
    enqueue(element){
        this.items.push(element);
    }
    dequeue(){
        this.items.shift();
    }
    isEmpty(){
        return this.items.length == 0;
    }
    peek(){
        if(!this.isEmpty()){
            return this.items[0];
        }
        return null;
    }
    size(){
        return this.items.length;
    }
    print(){
        console.log(this.items.toString());
    }
}

const ama = new Que();

console.log(ama.isEmpty());

ama.enqueue(10);
ama.enqueue(20);
ama.enqueue(30);

console.log(ama.print());

ama.dequeue();

console.log(ama.peek());
console.log(ama.size());

console.log(ama.print());

class Queue {
    constructor(){
        this.items = [];
    }

    enqueue(element){
        this.items.push = element;
    }

    dequeue(){
        return this.items.shift;
    }

    peek(){
        if(!this.isEmpty()){
            return this.items[0];
        }
        return null;
    }

    size(){
        return this.items.length;
    }

    isEmpty(){
        return this.items.length === 0;
    }

    print(){
        for(item of this.items){
            console.log(item)
        }
    }
}