# Namespace Journey.SurfaceWater
[更新记录](https://github.com/sm1lewc/Journey.SurfaceWater/blob/master/Journey.SurfaceWater/%E6%9B%B4%E6%96%B0%E8%AF%B4%E6%98%8E.md)

# 1 Journey.SurfaceWater.Enums 定义的枚举
## 1.1 Factor 监测指标  
没有完全延续总站以往的规定，稍微改动了,去掉"-"、"_"符号并全部大写，主要是为了方便编码。  

|单词/简写|说明|编码|
|:-------------:|:--------------:|:-----------------------:|
|WT|水温|w01010|
|PH|pH|w01001|
|DO|溶解氧|w01009|
|CODMN|高锰酸盐指数|w01019|
|COD|化学需氧量|w01018|
|BOD5|五日生化需氧量|w01017|
|NH3N|氨氮|w21003|
|TP|总磷|w21011|
|TN|总氮|w21001|
|CU|铜|w20122|
|ZN|锌|w20123|
|F|氟化物|w21017|
|SE|硒|w20128|
|AS|砷|w20141|
|HG|汞|w20111|
|CD|镉|w20115|
|CR6|六价铬|w20117|
|PB|铅|w20120|
|CN|氰化物|w21016|
|PHEN|挥发酚|w23002|
|TPH|石油类|w22001|
|LAS|阴离子表面活性剂|w19002|
|H2S|硫化物|w21019|
|FC|粪大肠菌群|w02003|
|SO42|硫酸盐|w21038|
|CL|氯化物|w21022|
|NO3|硝酸盐|w21007|
|FE|铁|w20125|
|MN|锰|w20124|
|MO|钼|w20061|
|CO|钴|w20038|
|BE|铍|w20127|
|B|硼|w20023|
|SB|锑|w20004|
|NI|镍|w20121|
|BA|钡|w20012|
|V|钒|w20101|
|TI|钛|w20095|
|TL|铊|w20089|

## 1.2 Waterbody 水体类型  
主要是为了在计算总磷的相关业务中使用，目前仅使用 河流/湖库，其他枚举返回Null。

## 1.3 WaterGrade 水质类别
|类别文本|类别值|
|:-------------:|:--------------:|
|Ⅰ|1|
|Ⅱ|2|
|Ⅲ|3|
|Ⅳ|4|
|Ⅴ|5|
|劣Ⅴ|6|
# 2 Journey.SurfaceWater.EQSFSW 地表水环境质量标准
## 2.1 V2002.GradeService 水质类别的相关计算
|方法名|说明|返回值|
|:-------------:|:--------------:|:--------------:|
|GetFactorGradeByAbbreviation|根据监测指标的简写计算指标的类别|(int,string)? eg. (4,Ⅳ)|
|GetFactorGradeByCode|根据监测指标的编码计算指标的类别|(int,string)?  eg. (4,Ⅳ)|
|Get{监测指标}Grade|计算监测指标的类别|(int,string)?  eg. (4,Ⅳ)|
|GetWaterGrade|计算整条数据的水质类别|Models.V2002.BasicItemValuesAndGrades|
## 2.2 V2002.StandardLimitService 标准限值的相关计算
|方法名|说明|返回值|
|:-------------:|:--------------:|:--------------:|
|GetPHLimit|获取PH的标准限值范围|(6,9)|
|Get{监测指标}Limits|获取监测指标Ⅰ-Ⅴ类标准限值|List\<StandardLimit\>|
|Get{监测指标}LimitByGrade|获取监测指标某一类别的标准限值|double?|
|GetFactorLimitByGradeAndFactor|根据指标的简写或者代码获取类别的标准限值<br>Get{监测指标}LimitByGrade方法的集中入口，不区分大小写|double?|
# 3 Journey.SurfaceWater.Factors 监测指标
## 3.1 FactorService 监测指标的相关计算
提供偷懒的方法，也可以通过枚举Enums.Factor获取  

|方法名|说明|返回值|
|:-------------:|:--------------:|:--------------:|
|GetFactorName|根据监测指标的缩写或者编码获取监测指标的名称|string?|
|GetFactorAbbreviationByCode|根据监测指标的编码获取监测指标的缩写|string?|
|GetFactorAbbreviationByName|根据监测指标的名称获取监测指标的缩写|string?|
|GetFactorCodeByAbbreviation|根据监测指标的缩写获取监测指标的编码|string?|
|GetFactorCodeByName|根据监测指标的名称获取监测指标的编码|string?|
# 4 Journey.SurfaceWater.Models 定义的模型
|类名|说明|
|:-------------:|:--------------:|
|V2002.BasicItemValues|GB 3838-2002《地表水环境质量标准》中表1的24个基本项目|
|V2002.BasicItemValuesAndGrades|继承BasicItemValues，增加各项指标水质类别及类别文本|
|StandardLimit|标准限值 {Grade,Limit}|