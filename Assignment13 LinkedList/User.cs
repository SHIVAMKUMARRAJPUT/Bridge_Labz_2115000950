using System;
using System.Collections.Generic;

class User{
    public int UserID;
    public string Name;
    public int Age;
    public List<int> FriendIDs;
    public User Next;

    public User(int userID, string name, int age){
        UserID = userID;
        Name = name;
        Age = age;
        FriendIDs = new List<int>();
        Next = null;
    }
}

class SocialMedia{
    private User head;

    public void AddUser(int userID, string name, int age){
        User newUser = new User(userID, name, age);
        newUser.Next = head;
        head = newUser;
    }

    public void AddFriendConnection(int userID1, int userID2){
        User user1 = FindUserByID(userID1);
        User user2 = FindUserByID(userID2);

        if (user1 != null && user2 != null && userID1 != userID2){
            if (!user1.FriendIDs.Contains(userID2)) user1.FriendIDs.Add(userID2);
            if (!user2.FriendIDs.Contains(userID1)) user2.FriendIDs.Add(userID1);
            Console.WriteLine("Friend connection added successfully");
        } else {
            Console.WriteLine("User(s) not found");
        }
    }

    public void RemoveFriendConnection(int userID1, int userID2){
        User user1 = FindUserByID(userID1);
        User user2 = FindUserByID(userID2);

        if (user1 != null && user2 != null){
            user1.FriendIDs.Remove(userID2);
            user2.FriendIDs.Remove(userID1);
            Console.WriteLine("Friend connection removed successfully");
        } else {
            Console.WriteLine("User(s) not found");
        }
    }

    public void FindMutualFriends(int userID1, int userID2){
        User user1 = FindUserByID(userID1);
        User user2 = FindUserByID(userID2);

        if (user1 != null && user2 != null){
            List<int> mutualFriends = user1.FriendIDs.FindAll(id => user2.FriendIDs.Contains(id));
            Console.WriteLine("Mutual Friends:");
            foreach (int id in mutualFriends){
                Console.WriteLine($"User ID: {id}");
            }
        } else {
            Console.WriteLine("User(s) not found");
        }
    }

    public void DisplayFriends(int userID){
        User user = FindUserByID(userID);
        if (user != null){
            Console.WriteLine($"Friends of {user.Name}:");
            foreach (int friendID in user.FriendIDs){
                Console.WriteLine($"User ID: {friendID}");
            }
        } else {
            Console.WriteLine("User not found");
        }
    }

    public void SearchUser(int userID, string name = ""){
        User temp = head;
        while (temp != null){
            if (temp.UserID == userID || temp.Name == name){
                Console.WriteLine($"User ID: {temp.UserID}, \nName: {temp.Name}, \nAge: {temp.Age}, \nFriends Count: {temp.FriendIDs.Count}\n");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("User not found");
    }

    private User FindUserByID(int userID){
        User temp = head;
        while (temp != null){
            if (temp.UserID == userID){
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }
}

class Test7{
    public static void Print(){
        SocialMedia sm = new SocialMedia();
        sm.AddUser(1, "Shivam", 25);
        sm.AddUser(2, "Aditya", 27);
        sm.AddUser(3, "Ashish", 22);
        sm.AddUser(4, "Vaibhav", 30);

        sm.AddFriendConnection(1, 2);
        sm.AddFriendConnection(1, 3);
        sm.AddFriendConnection(2, 4);

        Console.WriteLine("\n=== Display Friends ===");
        sm.DisplayFriends(1);

        Console.WriteLine("\n=== Mutual Friends ===");
        sm.FindMutualFriends(1, 2);

        Console.WriteLine("\n=== Searching for User ===");
        sm.SearchUser(2);

        Console.WriteLine("\n=== Removing Friend Connection  ===");
        sm.RemoveFriendConnection(1, 2);

        Console.WriteLine("\n=== Final Friends  ===");
        sm.DisplayFriends(1);
    }
}
