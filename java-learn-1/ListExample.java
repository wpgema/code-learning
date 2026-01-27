import java.util.ArrayList;
import java.util.List;

public class ListExample {
    public static void main(String[] args) {
        List<String> animals = new ArrayList<>();

        animals.add("fish");
        animals.add("cat");
        animals.add("elephant");
        animals.add("lion");
        animals.add("tiger");
        for (String animal : animals) {
            System.out.println(animal);
        }
        System.out.println("Size of the list: " + animals.size());
        System.out.println(animals.get(2));
    }
}
