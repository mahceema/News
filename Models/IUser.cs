using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using News.Models;

namespace News.Models
{
    public interface IUser
    {
        NewsEntities3 getDB();
        bool isValidUser(User refO);
        bool isExist(string refName);
        User getUserByName(string refName);

        void UpdateUser(User u);
        User AddUser(User u);
        Tag getTag(string tag);
        Tag AddTag(string tag);
        void AddPTag(Post p, Tag t);
        Post AddPost(Post p);
        List<Post> getWallPost(string username);
        Post getPostById(int id);
        void AddComment(Comment c);
    }
}
