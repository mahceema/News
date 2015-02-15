using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using News.Models;
namespace News.Models
{
    public class UserData:IUser 
    {
        private NewsEntities3 db = new NewsEntities3();

        public NewsEntities3 getDB()
        {
            return db;
        }
       
        public bool isValidUser(User refO)
        {
            User u = db.Users.Find(refO.username);
            if (u != null)
            {
                if (refO.password.Equals(u.password))
                    return true;
            }
            return false;
        }
        public bool isExist(string refName)
        {
            User u=db.Users.First(x=>x.username.Equals(refName));
            if (u != null)
                return true;

            return false;
        }
        public User getUserByName(string refName)
        {
            User u=db.Users.Find(refName);
            if(u!=null)
                return u;
            return null;
        }
        public User AddUser(User u)
        {
            u.first = DateTime.Now;
            u = db.Users.Add(u);
            db.SaveChanges();
            User awais = getUserByName("newsbox");
            if(awais!=null)
            {//Extra Lines other than last ones :P
                Tag tagu = db.Tags.Add(new Tag() { tags = u.username });
                db.SaveChanges();
                Tag taga = getTag("newsbox");
                awais.Tags.Add(tagu);
                u.Tags.Add(taga);
                db.SaveChanges();
            }
            return u;
        }
        public void UpdateUser(User u) 
        {
            User temp=db.Users.Find(u.username);
            temp.name = u.name;
            temp.password = u.password;
            temp.phone = u.phone;
            temp.profession = u.profession;
            temp.email = u.email;
            temp.dob = u.dob;
            db.SaveChanges();
        }
        public Tag getTag(string tag)
        {
            Tag temp;
            try
            {
                 temp = db.Tags.First(x=>x.tags.ToLower().Equals(tag.ToLower()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Data);
                return null;
            }
            return temp;
        }
        public Tag AddTag(string tag)
        {
            Tag t = new Tag();
            t.tags = tag.ToLower();
            t=db.Tags.Add(t);
            db.SaveChanges();
            return t;
        }
        public Post AddPost(Post p)
        {
            p=db.Posts.Add(p);
            db.SaveChanges();
            return p;
        }
        public void AddPTag(Post p, Tag t)
        {
            p.Tags.Add(t);
            //t.Posts.Add(p);
            db.SaveChanges();
        }
        public List<Post> getWallPost(string username)
        {
            return db.Posts.Where<Post>(x => x.uid.Equals(username)).ToList<Post>();
        }
        public Post getPostById(int id)
        {
            return db.Posts.Find(id);
        }
        public void AddComment(Comment c)
        {
            db.Comments.Add(c);
            db.SaveChanges();
        }

    }
}