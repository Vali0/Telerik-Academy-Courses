using System;
using System.Collections.Generic;

class Comment : ICommentable
{
    // Fields
    private List<string> comments = new List<string>();

    // Properties
    public List<string> GetComments
    {
        get
        {
            return this.comments;
        }
    }

    // Constructor
    public void AddComment(string comment)
    {
        this.comments.Add(comment);
    }

    public void RemoveComment(string comment)
    {
        this.comments.Remove(comment);
    }
}