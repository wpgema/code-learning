public class UserServiceImpl1 implements UserService{
    private int statusCode;

    public void setStatusCode(int statusCode){
        this.statusCode = statusCode;
    }

    public int getStatusCode(){
        return statusCode;
    }

    @Override
    public void saveUser(){
        System.out.println(statusCode + " Successfully add a user");
    }
}