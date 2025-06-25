using System.Collections.Generic;
using ToDoListProcess.Common;

public class UserManager //dito naman is for users authenticate for login and sa mga gustong magregister validations lang po sya kagaya ng ListManager

{
    private List<User> users;

    public UserManager(List<User> users)
    {
        this.users = users;
    }

    public bool Authenticate(string username, string password)
    {
        foreach (User user in users)
        {
            if (user.Username == username && user.Password == password)
            {
                return true;
            }
        }
        return false; 
    }

    public bool Register(string username, string password)
    {
        foreach (User user in users)
        {
            if (user.Username == username)
            {
                return false; // if Username already exists
            }
        }

        users.Add(new User(username, password));
        return true;
    }
}
