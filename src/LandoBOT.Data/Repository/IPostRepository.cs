using System;
using System.Collections.Generic;
using LandoBOT.Data.Models;

namespace LandoBOT.Data
{
	public interface IPostRepository
	{
		public Post GetPost(long id);
		public IEnumerable<Post> GetPosts();
		public void SavePost(Post post);
	}
}
