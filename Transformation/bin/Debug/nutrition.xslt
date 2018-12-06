<?xml version="1.0" encoding="utf-8"?>
<!--Created By: Dylan Cavanaugh-->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>


    <xsl:template match="*">

      <html xmlns ="http://www.w3.org/1999/xhtml">
        <head>
          <title>Nutrition</title>
        </head>

        <body>
          <table border="1" cellpadding="7px" style="background-color: blue">
            <tr>
              <th colspan ="4" style ="font-weight: bold; text-align: center">
                <xsl:value-of select ="name"/>
              </th>
            </tr>


            <tr>
              <td style ="font-weight: bold">
                Serving Size
              </td>
              <td>
                <xsl:value-of select ="servingSize"/>
              </td>
              <td style ="font-weight: bold">
                Total Calories
              </td>
              <td>
                <xsl:value-of select ="totalCalories"/>
              </td>
            </tr>
            <tr>
              <td style ="font-weight: bold">
                Sodium
              </td>
              <td>
                <xsl:value-of select ="sodium"/>
              </td>
              <td style ="font-weight: bold">
                Cholesterol
              </td>
              <td>
                <xsl:value-of select ="cholesterol"/>
              </td>
            </tr>
            <tr>
              <td style ="font-weight: bold">
                Carbohydrates
              </td>
              <td>
                <xsl:value-of select ="carbohydrates"/>
              </td>
              <td colspan ="2" style ="font-weight: bold; text-align: center">
                Fat
              </td>
            </tr>
             <tr>
              <td style ="font-weight: bold">
                Fiber
              </td>
              <td>
                <xsl:value-of select ="fiber"/>
              </td>
              <td style ="font-weight: bold">
                Calories
              </td>
              <td>
                <xsl:value-of select ="fat/calories"/>
              </td>
            </tr>
            <tr>
              <td style ="font-weight: bold">
                Sugar
              </td>
              <td>
                <xsl:value-of select ="sugar"/>
              </td>
              <td style ="font-weight: bold">
                Grams
              </td>
              <td>
                <xsl:value-of select ="fat/grams"/>
              </td>
            </tr>
            <tr>
              <td style ="font-weight: bold">
                Protein
              </td>
              <td>
                <xsl:value-of select ="protein"/>
              </td>
              <td style ="font-weight: bold">
                Saturated Fat
              </td>
              <td>
                <xsl:value-of select ="fat/saturatedFat"/>
              </td>
            </tr>
            
          
          </table>
        </body>
        
      </html>

    </xsl:template>
</xsl:stylesheet>
