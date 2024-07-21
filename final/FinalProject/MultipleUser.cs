using System;
using System.Collections.Generic;

public class UserProfileManager
{
    private List<UserProfile> userProfiles;

    public UserProfileManager()
    {
        userProfiles = new List<UserProfile>();
    }

    public void AddProfile(UserProfile profile)
    {
        userProfiles.Add(profile);
    }

    public UserProfile GetProfile(string username)
    {
        return userProfiles.Find(profile => profile.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
    }

    public void ListProfiles()
    {
        Console.WriteLine("User Profiles:");
        foreach (var profile in userProfiles)
        {
            Console.WriteLine($"Username: {profile.Username}, Email: {profile.Email}");
        }
    }
}

