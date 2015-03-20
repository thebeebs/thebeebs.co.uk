using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubToAzureTableStorage {

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class rss
	{

		private rssChannel channelField;

		private decimal versionField;

		/// <remarks/>
		public rssChannel channel
		{
			get
			{
				return this.channelField;
			}
			set
			{
				this.channelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public decimal version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class rssChannel
	{

		private string titleField;

		private string linkField;

		private string descriptionField;

		private string pubDateField;

		private string languageField;

		private decimal wxr_versionField;

		private string base_site_urlField;

		private string base_blog_urlField;

		private author authorField;

		private string generatorField;

		private rssChannelItem[] itemField;

		/// <remarks/>
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}

		/// <remarks/>
		public string link
		{
			get
			{
				return this.linkField;
			}
			set
			{
				this.linkField = value;
			}
		}

		/// <remarks/>
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		/// <remarks/>
		public string pubDate
		{
			get
			{
				return this.pubDateField;
			}
			set
			{
				this.pubDateField = value;
			}
		}

		/// <remarks/>
		public string language
		{
			get
			{
				return this.languageField;
			}
			set
			{
				this.languageField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://wordpress.org/export/1.2/")]
		public decimal wxr_version
		{
			get
			{
				return this.wxr_versionField;
			}
			set
			{
				this.wxr_versionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://wordpress.org/export/1.2/")]
		public string base_site_url
		{
			get
			{
				return this.base_site_urlField;
			}
			set
			{
				this.base_site_urlField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://wordpress.org/export/1.2/")]
		public string base_blog_url
		{
			get
			{
				return this.base_blog_urlField;
			}
			set
			{
				this.base_blog_urlField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://wordpress.org/export/1.2/")]
		public author author
		{
			get
			{
				return this.authorField;
			}
			set
			{
				this.authorField = value;
			}
		}

		/// <remarks/>
		public string generator
		{
			get
			{
				return this.generatorField;
			}
			set
			{
				this.generatorField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("item")]
		public rssChannelItem[] item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://wordpress.org/export/1.2/")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://wordpress.org/export/1.2/", IsNullable = false)]
	public partial class author
	{

		private byte author_idField;

		private string author_loginField;

		private string author_emailField;

		private string author_display_nameField;

		private string author_first_nameField;

		private string author_last_nameField;

		/// <remarks/>
		public byte author_id
		{
			get
			{
				return this.author_idField;
			}
			set
			{
				this.author_idField = value;
			}
		}

		/// <remarks/>
		public string author_login
		{
			get
			{
				return this.author_loginField;
			}
			set
			{
				this.author_loginField = value;
			}
		}

		/// <remarks/>
		public string author_email
		{
			get
			{
				return this.author_emailField;
			}
			set
			{
				this.author_emailField = value;
			}
		}

		/// <remarks/>
		public string author_display_name
		{
			get
			{
				return this.author_display_nameField;
			}
			set
			{
				this.author_display_nameField = value;
			}
		}

		/// <remarks/>
		public string author_first_name
		{
			get
			{
				return this.author_first_nameField;
			}
			set
			{
				this.author_first_nameField = value;
			}
		}

		/// <remarks/>
		public string author_last_name
		{
			get
			{
				return this.author_last_nameField;
			}
			set
			{
				this.author_last_nameField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class rssChannelItem
	{

		private string titleField;

		private string linkField;

		private string pubDateField;

		private string creatorField;

		private rssChannelItemGuid guidField;

		private object descriptionField;

		private string encodedField;

		private string encoded1Field;

		private ushort post_idField;

		private string post_dateField;

		private string post_date_gmtField;

		private string comment_statusField;

		private string ping_statusField;

		private string post_nameField;

		private string statusField;

		private byte post_parentField;

		private byte menu_orderField;

		private string post_typeField;

		private object post_passwordField;

		private byte is_stickyField;

		private rssChannelItemCategory[] categoryField;

		private postmeta[] postmetaField;

		private comment[] commentField;

		/// <remarks/>
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}

		/// <remarks/>
		public string link
		{
			get
			{
				return this.linkField;
			}
			set
			{
				this.linkField = value;
			}
		}

		/// <remarks/>
		public string pubDate
		{
			get
			{
				return this.pubDateField;
			}
			set
			{
				this.pubDateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/dc/elements/1.1/")]
		public string creator
		{
			get
			{
				return this.creatorField;
			}
			set
			{
				this.creatorField = value;
			}
		}

		/// <remarks/>
		public rssChannelItemGuid guid
		{
			get
			{
				return this.guidField;
			}
			set
			{
				this.guidField = value;
			}
		}

		/// <remarks/>
		public object description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/rss/1.0/modules/content/")]
		public string encoded
		{
			get
			{
				return this.encodedField;
			}
			set
			{
				this.encodedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("encoded", Namespace = "http://wordpress.org/export/1.2/excerpt/")]
		public string encoded1
		{
			get
			{
				return this.encoded1Field;
			}
			set
			{
				this.encoded1Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://wordpress.org/export/1.2/")]
		public ushort post_id
		{
			get
			{
				return this.post_idField;
			}
			set
			{
				this.post_idField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://wordpress.org/export/1.2/")]
		public string post_date
		{
			get
			{
				return this.post_dateField;
			}
			set
			{
				this.post_dateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://wordpress.org/export/1.2/")]
		public string post_date_gmt
		{
			get
			{
				return this.post_date_gmtField;
			}
			set
			{
				this.post_date_gmtField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://wordpress.org/export/1.2/")]
		public string comment_status
		{
			get
			{
				return this.comment_statusField;
			}
			set
			{
				this.comment_statusField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://wordpress.org/export/1.2/")]
		public string ping_status
		{
			get
			{
				return this.ping_statusField;
			}
			set
			{
				this.ping_statusField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://wordpress.org/export/1.2/")]
		public string post_name
		{
			get
			{
				return this.post_nameField;
			}
			set
			{
				this.post_nameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://wordpress.org/export/1.2/")]
		public string status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://wordpress.org/export/1.2/")]
		public byte post_parent
		{
			get
			{
				return this.post_parentField;
			}
			set
			{
				this.post_parentField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://wordpress.org/export/1.2/")]
		public byte menu_order
		{
			get
			{
				return this.menu_orderField;
			}
			set
			{
				this.menu_orderField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://wordpress.org/export/1.2/")]
		public string post_type
		{
			get
			{
				return this.post_typeField;
			}
			set
			{
				this.post_typeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://wordpress.org/export/1.2/")]
		public object post_password
		{
			get
			{
				return this.post_passwordField;
			}
			set
			{
				this.post_passwordField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://wordpress.org/export/1.2/")]
		public byte is_sticky
		{
			get
			{
				return this.is_stickyField;
			}
			set
			{
				this.is_stickyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("category")]
		public rssChannelItemCategory[] category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("postmeta", Namespace = "http://wordpress.org/export/1.2/")]
		public postmeta[] postmeta
		{
			get
			{
				return this.postmetaField;
			}
			set
			{
				this.postmetaField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("comment", Namespace = "http://wordpress.org/export/1.2/")]
		public comment[] comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class rssChannelItemGuid
	{

		private bool isPermaLinkField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool isPermaLink
		{
			get
			{
				return this.isPermaLinkField;
			}
			set
			{
				this.isPermaLinkField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class rssChannelItemCategory
	{

		private string domainField;

		private string nicenameField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string domain
		{
			get
			{
				return this.domainField;
			}
			set
			{
				this.domainField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string nicename
		{
			get
			{
				return this.nicenameField;
			}
			set
			{
				this.nicenameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://wordpress.org/export/1.2/")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://wordpress.org/export/1.2/", IsNullable = false)]
	public partial class postmeta
	{

		private string meta_keyField;

		private string meta_valueField;

		/// <remarks/>
		public string meta_key
		{
			get
			{
				return this.meta_keyField;
			}
			set
			{
				this.meta_keyField = value;
			}
		}

		/// <remarks/>
		public string meta_value
		{
			get
			{
				return this.meta_valueField;
			}
			set
			{
				this.meta_valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://wordpress.org/export/1.2/")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://wordpress.org/export/1.2/", IsNullable = false)]
	public partial class comment
	{

		private ushort comment_idField;

		private string comment_authorField;

		private string comment_author_emailField;

		private string comment_author_urlField;

		private string comment_author_IPField;

		private string comment_dateField;

		private string comment_date_gmtField;

		private string comment_contentField;

		private string comment_approvedField;

		private string comment_typeField;

		private ushort comment_parentField;

		private byte comment_user_idField;

		private commentCommentmeta[] commentmetaField;

		/// <remarks/>
		public ushort comment_id
		{
			get
			{
				return this.comment_idField;
			}
			set
			{
				this.comment_idField = value;
			}
		}

		/// <remarks/>
		public string comment_author
		{
			get
			{
				return this.comment_authorField;
			}
			set
			{
				this.comment_authorField = value;
			}
		}

		/// <remarks/>
		public string comment_author_email
		{
			get
			{
				return this.comment_author_emailField;
			}
			set
			{
				this.comment_author_emailField = value;
			}
		}

		/// <remarks/>
		public string comment_author_url
		{
			get
			{
				return this.comment_author_urlField;
			}
			set
			{
				this.comment_author_urlField = value;
			}
		}

		/// <remarks/>
		public string comment_author_IP
		{
			get
			{
				return this.comment_author_IPField;
			}
			set
			{
				this.comment_author_IPField = value;
			}
		}

		/// <remarks/>
		public string comment_date
		{
			get
			{
				return this.comment_dateField;
			}
			set
			{
				this.comment_dateField = value;
			}
		}

		/// <remarks/>
		public string comment_date_gmt
		{
			get
			{
				return this.comment_date_gmtField;
			}
			set
			{
				this.comment_date_gmtField = value;
			}
		}

		/// <remarks/>
		public string comment_content
		{
			get
			{
				return this.comment_contentField;
			}
			set
			{
				this.comment_contentField = value;
			}
		}

		/// <remarks/>
		public string comment_approved
		{
			get
			{
				return this.comment_approvedField;
			}
			set
			{
				this.comment_approvedField = value;
			}
		}

		/// <remarks/>
		public string comment_type
		{
			get
			{
				return this.comment_typeField;
			}
			set
			{
				this.comment_typeField = value;
			}
		}

		/// <remarks/>
		public ushort comment_parent
		{
			get
			{
				return this.comment_parentField;
			}
			set
			{
				this.comment_parentField = value;
			}
		}

		/// <remarks/>
		public byte comment_user_id
		{
			get
			{
				return this.comment_user_idField;
			}
			set
			{
				this.comment_user_idField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("commentmeta")]
		public commentCommentmeta[] commentmeta
		{
			get
			{
				return this.commentmetaField;
			}
			set
			{
				this.commentmetaField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://wordpress.org/export/1.2/")]
	public partial class commentCommentmeta
	{

		private string meta_keyField;

		private string meta_valueField;

		/// <remarks/>
		public string meta_key
		{
			get
			{
				return this.meta_keyField;
			}
			set
			{
				this.meta_keyField = value;
			}
		}

		/// <remarks/>
		public string meta_value
		{
			get
			{
				return this.meta_valueField;
			}
			set
			{
				this.meta_valueField = value;
			}
		}
	}



}
