using System;
using System.Collections.Generic;

interface ICommentable
{
    List<string> GetComments { get ; }// Here will save the comments

    void AddComment(string comment); // Method for adding comments
}