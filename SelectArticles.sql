SELECT	  a.Topic
		, TagName = t.Name
FROM dbo.Article AS a
	LEFT JOIN dbo.TagRelation AS tr
		ON tr.ArticleId = a.Id
	LEFT JOIN dbo.Tag AS t
		ON tr.TagId = t.Id
