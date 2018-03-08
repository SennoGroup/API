using System;
using System.Collections.Generic;

namespace SocialNetwork
{
    public class BaseEntry
    {
        public string ID { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }

    public interface IFacebookExtractor
    {
        List<BaseEntry> GetPageItems(string pageId, int count);
        List<BaseEntry> GetComments(string objectId, int count);
        List<BaseEntry> GetMentions(string pageId, int count);
    }

    public interface ITwitterExtractor
    {
        List<BaseEntry> GetUserTweets(int userId, int sinceId, int maxId, int count);
        List<BaseEntry> GetHashtagTweets(string hashtag, int sinceId, int maxId, int count);
        List<BaseEntry> GetMentionTweets(int userId, int sinceId, int maxId, int count);
        List<BaseEntry> GetListTweets(int listId, int sinceId, int maxId, int count);
    }

    public interface IGooglePlusExtractor
    {
        List<BaseEntry> GetUserActivities(string userId, int count);
        List<BaseEntry> GetActivityComments(string activityId, int count);
    }

    public interface IInstagramExtractor
    {
        List<BaseEntry> GetUserMediaCaption(int userId, int minId, int maxId, int count);
        List<BaseEntry> GetHashtagMediaCaption(string tagName, int minTagId, int maxTagId, int count);
        List<BaseEntry> GetMediaComments(int mediaId);
    }

    public interface ILinkedInExtractor
    {
        List<BaseEntry> GetUserShares(string ownerId, int offset, int count);
        List<BaseEntry> GetUserArticles(string ownerId, int offset, int count);
        List<BaseEntry> GetComments(string ownerId, string commentId, int offset, int count);
    }

    public interface IRedditExtractor
    {
        List<BaseEntry> SearchSubreddits(string subreddit, string query, int count);
        List<BaseEntry> GetComments(string subreddit, string link, int count);
    }

    public interface ITumblrExtractor
    {
        List<BaseEntry> GetBlogPosts(int blogId, int offset, int count);
    }

    public interface IVkExtractor
    {
        List<BaseEntry> GetUserPosts(int ownerId, int offset, int count);
        List<BaseEntry> GetComments(int ownerId, int postId, int offset, int count);
    }

    public interface ITelegramExtractor
    {
        List<BaseEntry> GetHistory(int chatId, int offset, int count);
    }
}