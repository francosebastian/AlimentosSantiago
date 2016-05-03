<?xml version="1.0" encoding="utf-16" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:import href="Master.xslt"/>
  <xsl:template name="contenido">
    <p style="font-style: normal;padding-bottom: 0px; line-height: 12px; margin-top: 0px; padding-left: 0px; padding-right: 0px; font-family:'Calibri',sans-serif;color:black;font-size: 11px; padding-top: 0px">
      Estimada(o)
      <br />
      <br />
      Las siguientes Notas de venta han sido enviadas a Bodega.
    </p>
    <table style="border-collapse: collapse; border: 1px solid black">
      <tr style="border-collapse: collapse; border: 1px solid black">
        <td style="border-collapse: collapse; border: 1px solid black">
          <span style="font-family:&quot;Calibri&quot;,sans-serif;color:black;font-size:11px;font-weight:bold">Nota de Venta</span>
        </td>
        <td style="border-collapse: collapse; border: 1px solid black">
          <span style="font-family:&quot;Calibri&quot;,sans-serif;color:black;font-size:11px;font-weight:bold">Tipo</span>
        </td>
        <td style="border-collapse: collapse; border: 1px solid black">
          <span style="font-family:&quot;Calibri&quot;,sans-serif;color:black;font-size:11px;font-weight:bold">Centro</span>
        </td>
        <td style="border-collapse: collapse; border: 1px solid black">
          <span style="font-family:&quot;Calibri&quot;,sans-serif;color:black;font-size:11px;font-weight:bold">Fecha</span>
        </td>
      </tr>
      <xsl:for-each select="NotasVenta/NotaVenta">
        <tr style="border-collapse: collapse; border: 1px solid black">
          <td style="border-collapse: collapse; border: 1px solid black">
            <span style="font-family:&quot;Calibri&quot;,sans-serif;color:black;font-size:11px">
              <xsl:value-of select="Id"/>
            </span>
          </td>
          <td style="border-collapse: collapse; border: 1px solid black">
            <span style="font-family:&quot;Calibri&quot;,sans-serif;color:black;font-size:11px">
              <xsl:value-of select="TipoVenta/Descripcion"/>
            </span>
          </td>
          <td style="border-collapse: collapse; border: 1px solid black">
            <span style="font-family:&quot;Calibri&quot;,sans-serif;color:black;font-size:11px">
              <xsl:value-of select="Centro/Nombre"/>
            </span>
          </td>
          <td style="border-collapse: collapse; border: 1px solid black">
            <span style="font-family:&quot;Calibri&quot;,sans-serif;color:black;font-size:11px">
              <xsl:value-of select="FechaPresentable"/>
            </span>
          </td>
        </tr>
      </xsl:for-each>
    </table>
    <br />
    <br />
    <br />

    <p class="MsoNormal">
      <b>
        <span style="font-family:'Calibri',sans-serif;color:black;font-size:11px">
          Por favor, no responda a esta casilla de correo, este es un mensaje informativo automático y no es monitoreado por el sistema.
        </span>
      </b>
    </p>
    <br />
  </xsl:template>
</xsl:stylesheet>
