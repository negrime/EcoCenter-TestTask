<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="bookStore">
    <HTML>
      <BODY>
        <TABLE cellpadding="15" cellspacing="1" align="center" BORDER="1">
          <TR>
            <TH>title</TH>
            <TH>author</TH>
            <TH>category</TH>
            <TH>price</TH >
          </TR>
          <xsl:apply-templates select="bookList"/>
        </TABLE>
      </BODY>
    </HTML>
  </xsl:template>
  <xsl:template match="bookList">
   <xsl:for-each select="book">
    <TR>
      <TD>
        <xsl:value-of select="Title"/>
      </TD>
 
      <TD>
        <xsl:apply-templates select="authors"/>
        <xsl:for-each select="authors">
       </xsl:for-each>
      </TD>
      
      
      <TD>
        <xsl:value-of select="@category"/>
      </TD>
      <TD>
        <xsl:value-of select="Price"/>
      </TD>
    </TR>
     </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>