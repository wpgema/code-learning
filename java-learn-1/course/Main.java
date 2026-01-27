public class Main {

    public static void main(String[] args) {

        UserService service = new UserService();

        service.addUser(new User(1, "Gema"));
        service.addUser(new User(2, "Budi"));

        for (User user : service.getAllUsers()) {
            System.out.println(user.getName());
        }

        User user = service.getUserById(1);
        System.out.println(user.getName());
    }
}
