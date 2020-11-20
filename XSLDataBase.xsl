<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html"></xsl:output>

    <xsl:template match="/">
        <html>
            <body>
                <table border ="1">
                    <TR>
						<th>NameOfTheGame</th>
                        <th>Developer</th>
                        <th>ReleaseDate</th>
                        <th>MainGenre</th>
                        <th>GameMode</th>
                        <th>Engine</th>
                        <th>Metascore</th>
                    </TR>
                    <xsl:for-each select ="GameDataBase/Game">
                        <tr>
                            <td>
                                <xsl:value-of select ="@NameOfTheGame"/>
                            </td>
                            <td>
                                <xsl:value-of select ="@Developer"/>
                            </td>
                            <td>
                                <xsl:value-of select ="@ReleaseDate"/>
                            </td>
                            <td>
                                <xsl:value-of select ="@MainGenre"/>
                            </td>
                            <td>
                                <xsl:value-of select ="@GameMode"/>
                            </td>
                            <td>
                                <xsl:value-of select ="@Engine"/>
                            </td>
							<td>
								<xsl:value-of select ="@Metascore"/>
							</td>
                        </tr>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>