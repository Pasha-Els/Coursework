/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
SELECT TOP (1000) [idsite]
      ,[Addresssite]
      ,[Siteview]
      ,[Promotion]
      ,[Hosting]
  FROM [ПСП].[dbo].[Site]