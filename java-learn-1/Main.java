public class Main {
    public static void main(String[] args) {
        UserService user = new UserServiceImpl();
        UserServiceImpl1 user1 = new UserServiceImpl1();
        user.saveUser();
        System.out.println(user1.getStatusCode());
        user1.setStatusCode(200);
        user1.saveUser();
    }
}
