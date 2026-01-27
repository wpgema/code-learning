import java.util.HashMap;
import java.util.Map;

public class MapExample{
    public static void main(String[] args){
        Map<String, Integer> fruitCalories = new HashMap<>();
        fruitCalories.put("Apple", 95);
        fruitCalories.put("Banana", 105);
        fruitCalories.put("Orange", 62);
        for (String fruit : fruitCalories.keySet()) {
            System.out.println(fruit + ": " + fruitCalories.get(fruit) + " calories");
        }
    }
}