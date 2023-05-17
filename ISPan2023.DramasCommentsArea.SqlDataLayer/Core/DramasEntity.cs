using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Dramas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer.Core
{
	public class DramasEntity
	{
		public int Id { get; private set; }
		public string Name { get; private set; }
		public int Episode { get; private set; }
		public DateTime PublishDate { get; private set; }
		public string Ott { get; private set; }
		public string Description { get; private set; }
		public string Writer { get; private set; }
		public string Director { get; private set; }
		public string Actors { get; private set; }
		public string Path { get; private set; }
		public DramasEntity(DramasDto dto)
		{
			this.Id = dto.Id;
			this.Name = dto.Name;
			this.Episode = dto.Episode;
			this.PublishDate = dto.PublishDate;
			this.Ott = dto.Ott;
			this.Description = dto.Description;
			this.Writer = dto.Writer;
			this.Director = dto.Director;
			this.Actors = dto.Actors;
			this.Path = dto.Path;
		}
		public DramasEntity(DramasAddDto dto)
		{
			this.Id = 0;
			this.Name = dto.Name;
			this.Episode = dto.Episode;
			this.PublishDate = dto.PublishDate;
			this.Ott = dto.Ott;
			this.Description = dto.Description;
			this.Writer = dto.Writer;
			this.Director = dto.Director;
			this.Actors = dto.Actors;
			this.Path = dto.Path;
		}
		public DramasEntity(DramasEditDto dto)
		{
			this.Id = dto.Id;
			this.Name = dto.Name;
			this.Episode = dto.Episode;
			this.PublishDate = dto.PublishDate;
			this.Ott = dto.Ott;
			this.Description = dto.Description;
			this.Writer = dto.Writer;
			this.Director = dto.Director;
			this.Actors = dto.Actors;
			this.Path = dto.Path;
		}
		//public DramasEntity(string name, int episode, DateTime publishDate, string ott, string description,
		//	string writer, string director, string actors, string path, int id = 0)
		//{
		//	this.Id = id;
		//	this.Name = name;
		//	this.Episode = episode;
		//	this.PublishDate = publishDate;
		//	this.Ott = ott;
		//	this.Description = description;
		//	this.Writer = writer;
		//	this.Director = director;
		//	this.Actors = actors;
		//	this.Path = path;
		//}
	}
}
