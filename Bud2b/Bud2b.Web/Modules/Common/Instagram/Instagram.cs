using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Bud2b.Modules.Common.Instagram
{
    public class Instagram
    {
        public class FollowedBy
        {
            public int count { get; set; }
        }

        public class Follows
        {
            public int count { get; set; }
        }

        public class Dimensions
        {
            public int height { get; set; }
            public int width { get; set; }
        }

        public class EdgeMediaPreviewLike
        {
            public int count { get; set; }
        }

        public class Owner
        {
            public string id { get; set; }
        }

        public class ThumbnailResource
        {
            public string src { get; set; }
            public int config_width { get; set; }
            public int config_height { get; set; }
        }

        public class Comments
        {
            public int count { get; set; }
        }

        public class Likes
        {
            public int count { get; set; }
        }

        public class Node
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public bool comments_disabled { get; set; }
            public Dimensions dimensions { get; set; }
            public EdgeMediaPreviewLike edge_media_preview_like { get; set; }
            public object gating_info { get; set; }
            public string media_preview { get; set; }
            public Owner owner { get; set; }
            public string thumbnail_src { get; set; }
            public List<ThumbnailResource> thumbnail_resources { get; set; }
            public bool is_video { get; set; }
            public string code { get; set; }
            public int date { get; set; }
            public string display_src { get; set; }
            public int video_views { get; set; }
            public string caption { get; set; }
            public Comments comments { get; set; }
            public Likes likes { get; set; }
        }

        public class PageInfo
        {
            public bool has_next_page { get; set; }
            public string end_cursor { get; set; }
        }

        public class Media
        {
            public List<Node> nodes { get; set; }
            public int count { get; set; }
            public PageInfo page_info { get; set; }
        }

        public class PageInfo2
        {
            public bool has_next_page { get; set; }
            public object end_cursor { get; set; }
        }

        public class SavedMedia
        {
            public List<object> nodes { get; set; }
            public int count { get; set; }
            public PageInfo2 page_info { get; set; }
        }

        public class PageInfo3
        {
            public bool has_next_page { get; set; }
            public object end_cursor { get; set; }
        }

        public class MediaCollections
        {
            public int count { get; set; }
            public PageInfo3 page_info { get; set; }
            public List<object> edges { get; set; }
        }

        public class User
        {
            public object biography { get; set; }
            public bool blocked_by_viewer { get; set; }
            public bool country_block { get; set; }
            public object external_url { get; set; }
            public object external_url_linkshimmed { get; set; }
            public FollowedBy followed_by { get; set; }
            public bool followed_by_viewer { get; set; }
            public Follows follows { get; set; }
            public bool follows_viewer { get; set; }
            public string full_name { get; set; }
            public bool has_blocked_viewer { get; set; }
            public bool has_requested_viewer { get; set; }
            public string id { get; set; }
            public bool is_private { get; set; }
            public bool is_verified { get; set; }
            public object mutual_followers { get; set; }
            public string profile_pic_url { get; set; }
            public string profile_pic_url_hd { get; set; }
            public bool requested_by_viewer { get; set; }
            public string username { get; set; }
            public object connected_fb_page { get; set; }
            public Media media { get; set; }
            public SavedMedia saved_media { get; set; }
            public MediaCollections media_collections { get; set; }
        }

        public class EdgeFollowedBy
        {
            public int count { get; set; }
        }

        public class EdgeFollow
        {
            public int count { get; set; }
        }

        public class PageInfo4
        {
            public bool has_next_page { get; set; }
            public string end_cursor { get; set; }
        }

        public class EdgeMediaToCaption
        {
            public List<object> edges { get; set; }
        }

        public class EdgeMediaToComment
        {
            public int count { get; set; }
        }

        public class Dimensions2
        {
            public int height { get; set; }
            public int width { get; set; }
        }

        public class EdgeLikedBy
        {
            public int count { get; set; }
        }

        public class EdgeMediaPreviewLike2
        {
            public int count { get; set; }
        }

        public class Owner2
        {
            public string id { get; set; }
        }

        public class ThumbnailResource2
        {
            public string src { get; set; }
            public int config_width { get; set; }
            public int config_height { get; set; }
        }

        public class Node2
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public EdgeMediaToCaption edge_media_to_caption { get; set; }
            public string shortcode { get; set; }
            public EdgeMediaToComment edge_media_to_comment { get; set; }
            public bool comments_disabled { get; set; }
            public int taken_at_timestamp { get; set; }
            public Dimensions2 dimensions { get; set; }
            public string display_url { get; set; }
            public EdgeLikedBy edge_liked_by { get; set; }
            public EdgeMediaPreviewLike2 edge_media_preview_like { get; set; }
            public object gating_info { get; set; }
            public string media_preview { get; set; }
            public Owner2 owner { get; set; }
            public string thumbnail_src { get; set; }
            public List<ThumbnailResource2> thumbnail_resources { get; set; }
            public bool is_video { get; set; }
            public int video_view_count { get; set; }
        }

        public class Edge
        {
            public Node2 node { get; set; }
        }

        public class EdgeOwnerToTimelineMedia
        {
            public int count { get; set; }
            public PageInfo4 page_info { get; set; }
            public List<Edge> edges { get; set; }
        }

        public class PageInfo5
        {
            public bool has_next_page { get; set; }
            public object end_cursor { get; set; }
        }

        public class EdgeSavedMedia
        {
            public int count { get; set; }
            public PageInfo5 page_info { get; set; }
            public List<object> edges { get; set; }
        }

        public class PageInfo6
        {
            public bool has_next_page { get; set; }
            public object end_cursor { get; set; }
        }

        public class EdgeMediaCollections
        {
            public int count { get; set; }
            public PageInfo6 page_info { get; set; }
            public List<object> edges { get; set; }
        }

        public class User2
        {
            public string biography { get; set; }
            public bool blocked_by_viewer { get; set; }
            public bool country_block { get; set; }
            public object external_url { get; set; }
            public object external_url_linkshimmed { get; set; }
            public EdgeFollowedBy edge_followed_by { get; set; }
            public bool followed_by_viewer { get; set; }
            public EdgeFollow edge_follow { get; set; }
            public bool follows_viewer { get; set; }
            public string full_name { get; set; }
            public bool has_blocked_viewer { get; set; }
            public bool has_requested_viewer { get; set; }
            public string id { get; set; }
            public bool is_private { get; set; }
            public bool is_verified { get; set; }
            public object mutual_followers { get; set; }
            public string profile_pic_url { get; set; }
            public string profile_pic_url_hd { get; set; }
            public bool requested_by_viewer { get; set; }
            public string username { get; set; }
            public object connected_fb_page { get; set; }
            public EdgeOwnerToTimelineMedia edge_owner_to_timeline_media { get; set; }
            public EdgeSavedMedia edge_saved_media { get; set; }
            public EdgeMediaCollections edge_media_collections { get; set; }
        }

        public class Graphql
        {
            public User2 user { get; set; }
        }

        public class RootObject
        {
            public User user { get; set; }
            public string logging_page_id { get; set; }
            public bool show_suggested_profiles { get; set; }
            public Graphql graphql { get; set; }
        }

    }
}