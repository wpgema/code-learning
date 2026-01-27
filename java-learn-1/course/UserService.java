import java.util.HashMap;
import java.util.Map;

public class UserService {
    Map<Integer, User> userMap = new HashMap<>();

    public void addUser(User user) {
        userMap.put(user.getId(), user);
    }

    public User getUserById(int id) {
        return userMap.get(id);
    }

    public Iterable<User> getAllUsers() {
        return userMap.values();
    }
}