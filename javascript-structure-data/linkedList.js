class Node{
    constructor(value){
        this.value =  value;
        this.next = null;
    }
}

class LinkedList{
    constructor(){
        this.head = null;
        this.size = 0;
    }

    isEmpty(){
        return this.size === 0;
    }

    getSize(){
        return this.size;
    }

    prepend(value){
        const node = new Node(value);
        if(this.isEmpty()){
            this.head = node;
        } else {
            node.next = this.head;
            this.head = node;
        }
        this.size++;
    }

    append(value){
        const node = new Node(value);
        if(this.isEmpty()){
            this.head = node;
        } else {
            let prev = this.head;
            while(prev.next){
                prev = prev.next;
            }
            prev.next = node;
        }
        this.size++;
    }

    insert(value, index){
        if(index < 0 || index > this.size){
            return
        }
        if(index === 0){
            this.prepend(value)
        } else {
            const node = new Node(value);
            let prev = this.head;
            for(let i = 0; i < index - 1; i++){
                prev = prev.next;
            }
            node.next = prev.next;
            prev.next = node;
            this.size++;
        }
    }

    removeFrom(index){
        if(index < 0 || index >= this.size){
            return null;
        }
        let removedNode;
        if(index === 0){
            removedNode = this.head;
            this.head = this.head.next;
        } else {
            let prev = this.head;
            for(let i = 0; i < index - 1; i++){
                prev = prev.next;
            }
            removedNode = prev.next;
            prev.next = removedNode.next;
        }
        this.size--;
        return removedNode.value
    }

    debug(){
        console.log(this.append());
    }

    print(){
        if(this.isEmpty()){
            console.log(`List is empty`);
        } else {
            let curr = this.head;
            let listValues = "";
            while(curr){
                listValues += ` ${curr.value}`;
                curr = curr.next;
            }
            console.log(listValues)
        }
    }
}

const list = new LinkedList();
// console.log(`linked list empty ? ${list.isEmpty()}`);
// console.log(`linked list size ? ${list.getSize()}`);

// list.append(10);
// list.print();

// list.prepend(10);
// list.prepend(20);

// list.append(20);
// list.append(30);
// list.append(40);
// list.append(50);

// list.insert(10, 0);
// list.insert(20);
// list.insert(30);
// list.print();
// list.debug();

list.insert(20, 0);
list.insert(30, 1);
list.insert(40, 1);
// list.print();

// list.insert(30, 1);
list.print();

// list.insert(40);
// list.print();

// console.log(list.getSize());

// console.log(list.removeFrom(10));

// console.log(list.removeFrom(0));
// list.print();

// console.log(list.removeFrom(1));
// list.print();
// console.log(list.getSize());