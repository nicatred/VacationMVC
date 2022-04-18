--/****** Script for SelectTopNRows command from SSMS  ******/
--SELECT*
--  FROM [Vaction].[dbo].[VacationRequests]


  --select substring(cast(year(getdate()) as varchar),3,2) + '-'+
  --case len(cast(month(getdate()) as varchar)) 
  --when 1 then '0' + cast(month(getdate()) as varchar) 
  --else cast(month(getdate()) as varchar) end 

  alter procedure GenerateRequestNumber (@UserId varchar)
  as
  begin
	declare @Prefix varchar(8), @LastRequestNo varchar(15), @LastRequestNumberAsInt int, @NewRequestNo varchar(15),@LastQuesitonId int
	
	set @LastQuesitonId = (select top 1 vr.Id from VacationRequests vr 
	                              where vr.UserId= @UserId
								  order by vr.CreatedDate desc)
	set @Prefix = 'Q-' + (select right(cast(year(getdate()) as varchar),2) + '-'+
											case len(cast(month(getdate()) as varchar)) 
											  when 1 then '0' + cast(month(getdate()) as varchar) 
											  else cast(month(getdate()) as varchar) end)
	set @LastRequestNo = (SELECT top 1 RequestNo 
								FROM VacationRequests 
									where RequestNo like @Prefix + '%' order by RequestNo desc)

	set @LastRequestNumberAsInt = case when @LastRequestNo is null then 1 else cast(right(@LastRequestNo,4) as int) + 1 end
	
	set @NewRequestNo = @Prefix + '-' + REPLICATE('0', 4 - len(cast(@LastRequestNumberAsInt as varchar))) + cast(@LastRequestNumberAsInt as varchar)
	 
	update VacationRequests set RequestNo = @NewRequestNo where Id = @LastQuesitonId

  end



  --SELECT * FROM [Vaction].[dbo].[VacationRequests]