<?xml version="1.0" encoding="utf-16" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="xml" encoding="iso-8859-15" doctype-system="http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" doctype-public="-//W3C//DTD XHTML 1.0 Transitional//EN" indent="no"/>
  <xsl:decimal-format decimal-separator="," grouping-separator="." />
  <xsl:template match="PresentadorCorreo">
    <html xmlns="http://www.w3.org/1999/xhtml">
      <head>
        <title>Alimentos Santiago </title>
      </head>
      <body>
        <div style="padding-bottom: 0px; margin: 0px; padding-left: 0px; padding-right: 0px; background: #f8f8f8; padding-top: 0px;font-style:normal">
          <table cellspacing="0" cellpadding="0" align="center" style="padding-bottom: 0px; margin: 0px; padding-left: 0px; width: 100%; padding-right: 0px; background: #f8f8f8; padding-top: 0px">
            <tbody>
              <tr>
                <td bgcolor="#f8f8f8">
                  &#160;
                </td>
                <td bgcolor="#f8f8f8">
                </td>
                <td bgcolor="#f8f8f8">
                  &#160;
                </td>
              </tr>
              <tr>
                <td bgcolor="#f8f8f8">
                  &#160;
                </td>
                <td width="718" style="border-left: #dddee1 1px solid; border-bottom: #dddee1 1px solid; border-top: #dddee1 1px solid; padding-bottom: 0px; margin: 0px; padding-left: 0px; width: 718px; padding-right: 0px; border-right: #dddee1 1px solid; padding-top: 0px">
                  <table width="718" cellspacing="0" cellpadding="0" border="0" style="padding-bottom: 0px; margin: 0px; padding-left: 0px; padding-right: 0px; font: 400 12px/16px arial,verdana,sans-serif; background: #fff; padding-top: 0px">
                    <tbody>
                      <tr>
                        <td width="718" valign="top" style="padding-left: 25px; width: 718px; padding-right: 28px" colspan="4">
                          <br />
                          <p style="padding-bottom: 0px; line-height: 12px; margin-top: 0px; padding-left: 0px; padding-right: 0px; font-family:'Calibri',sans-serif;color:black;font-size: 11px; padding-top: 0px;font-weight:bold">
                            <strong>
                              <xsl:value-of select="Titulo"></xsl:value-of>
                            </strong>
                            <em>
                            </em>
                          </p>
                          <xsl:call-template name="contenido"></xsl:call-template>
                        </td>
                      </tr>
                      <tr style="line-height:1px">
                        <td width="100%" bgcolor="#009a3e" style="line-height:3px; color:#ed4514">
                        </td>
                      </tr>
                      <tr>
                        <td colspan="2" align="left">
                          <br />
                          <img src="http://image.prntscr.com/image/a1d602446c5d46a899d39a2f33457cb8.png" alt="Alimentos Santiago" border="10" width="250" height="145" />
                          <xsl:text disable-output-escaping="yes"><![CDATA[&nbsp;]]></xsl:text>
                          <xsl:text disable-output-escaping="yes"><![CDATA[&nbsp;]]></xsl:text>
                          <br />
                        </td>
                        <td colspan="2">
                          <br />
                          <xsl:text disable-output-escaping="yes"><![CDATA[&nbsp;]]></xsl:text>
                          <xsl:text disable-output-escaping="yes"><![CDATA[&nbsp;]]></xsl:text>
                          <a href="http://www.alimentossantiago.cl/" style="color: #376aac">alimentossantiago.cl</a>
                          <br />
                        </td>
                      </tr>
                    </tbody>
                  </table>
                </td>
                <td bgcolor="#f8f8f8">
                  &#160;
                </td>
              </tr>
              <tr>
                <td bgcolor="#f8f8f8">
                  &#160;
                </td>
                <td>
                </td>
                <td bgcolor="#f8f8f8">
                  &#160;
                </td>
              </tr>
            </tbody>
          </table>
          <div>
          </div>
        </div>
      </body>
    </html>
  </xsl:template>
  <xsl:template name="contenido">
    <span style="color: red">Probando envio de correo.</span>
  </xsl:template>
</xsl:stylesheet>
