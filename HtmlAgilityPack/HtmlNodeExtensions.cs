namespace HtmlAgilityPack
{
	public static class HtmlNodeExtensions
	{
		public static int GetInnerStartIndex(this HtmlNode node)
		{
			return node._innerstartindex;
		}

		public static int GetInnerLength(this HtmlNode node)
		{
			return node._innerlength;
		}

		public static int GetOuterStartIndex(this HtmlNode node)
		{
			return node._outerstartindex;
		}

		public static int GetOuterLength(this HtmlNode node)
		{
			return node._outerlength;
		}

		public static HtmlNode GetEndNode(this HtmlNode node)
		{
			return node._endnode;
		}
	}
}
