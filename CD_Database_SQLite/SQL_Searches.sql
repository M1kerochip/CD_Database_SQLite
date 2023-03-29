Insert into Queries (Query_Name, Query_SQL_Text) Values ('Show [All] Files', 'select Files.ID, IFNULL(Corrections_Files.Corrected_Name, Files.Filename) as Filename, IFNULL(Corrections_Directory.Corrected_Directory, Files.Directory) as Directory, printf("%,d",Size) as Size, Date, Volume, Files.Watched, Series.Name as IMDB_Series_Name, Episode_ID from Files 
left join Corrections_Files on files.id = Corrections_Files.Match_ID 
left join Corrections_Directory on files.id = Corrections_Directory.Match_ID 
left join Series on Series.ID = Files.Series_ID
inner join Volumes on Files.Volume_ID = Volumes.ID 
order by Directory,Filename asc;');


Insert into Queries (Query_Name, Query_SQL_Text) Values ('Show [All] Music Only', 'select Files.ID, IFNULL(Corrections_Files.Corrected_Name, Files.Filename) as Filename, IFNULL(Corrections_Directory.Corrected_Directory, Files.Directory) as Directory, printf("%,d",Size) as Size, Date, Volume, Files.Watched, Series.Name as IMDB_Series_Name, Episode_ID from Files 
left join Corrections_Files on files.id = Corrections_Files.Match_ID 
left join Corrections_Directory on files.id = Corrections_Directory.Match_ID 
left join Series on Series.ID = Files.Series_ID
inner join Volumes on Files.Volume_ID = Volumes.ID
Where(
Filename like ''%.mp3''
or Filename like ''%.mp2''
or Filename like ''%.wma''
or Filename like ''%.flac''
or Filename like ''%.ogg''
or Filename like ''%.mod''
) 
order by Directory,Filename asc;');


Insert into Queries (Query_Name, Query_SQL_Text) Values ('Show [All] Video Only', 'select Files.ID, IFNULL(Corrections_Files.Corrected_Name, Files.Filename) as Filename, IFNULL(Corrections_Directory.Corrected_Directory, Files.Directory) as Directory, printf("%,d",Size) as Size, Date, Volume, Files.Watched, Series.Name as IMDB_Series_Name, Episode_ID from Files 
left join Corrections_Files on files.id = Corrections_Files.Match_ID 
left join Corrections_Directory on files.id = Corrections_Directory.Match_ID 
left join Series on Series.ID = Files.Series_ID
inner join Volumes on Files.Volume_ID = Volumes.ID
Where (
Filename like ''%.mkv''
or Filename like ''%.mp4''
or Filename like ''%.mov''
or Filename like ''%.wmv''
or Filename like ''%.avi''
or Filename like ''%.flv''
or Filename like ''%.mpg''
or Filename like ''%.mpe''
or Filename like ''%.mpeg''
or Filename like ''%.3gpp''
or Filename like ''%.asf''
or Filename like ''%.asx''
or Filename like ''%.avs''
or Filename like ''%.divx''
or Filename like ''%.m2t''
or Filename like ''%.m2ts''
or Filename like ''%.m4v''
or Filename like ''%.mts''
or Filename like ''%.ts''
)
order by Directory,Filename asc;');


Insert into Queries (Query_Name, Query_SQL_Text) Values ('Show [All] Video Only (+Zip)', 'select Files.ID, IFNULL(Corrections_Files.Corrected_Name, Files.Filename) as Filename, IFNULL(Corrections_Directory.Corrected_Directory, Files.Directory) as Directory, printf("%,d",Size) as Size, Date, Volume, Files.Watched, Series.Name as IMDB_Series_Name, Episode_ID from Files 
left join Corrections_Files on files.id = Corrections_Files.Match_ID 
left join Corrections_Directory on files.id = Corrections_Directory.Match_ID 
left join Series on Series.ID = Files.Series_ID
inner join Volumes on Files.Volume_ID = Volumes.ID
Where (
Filename like ''%.mkv''
or Filename like ''%.mp4''
or Filename like ''%.mov''
or Filename like ''%.wmv''
or Filename like ''%.avi''
or Filename like ''%.flv''
or Filename like ''%.mpg''
or Filename like ''%.mpe''
or Filename like ''%.mpeg''
or Filename like ''%.3gpp''
or Filename like ''%.asf''
or Filename like ''%.asx''
or Filename like ''%.avs''
or Filename like ''%.divx''
or Filename like ''%.m2t''
or Filename like ''%.m2ts''
or Filename like ''%.m4v''
or Filename like ''%.mts''
or Filename like ''%.ts''
or Filename like ''%.zip''
or Filename like ''%.z0%''
or Filename like ''%.z1%''
or Filename like ''%.z2%''
or Filename like ''%.z3%''
or Filename like ''%.z4%''
or Filename like ''%.z5%''
or Filename like ''%.z6%''
or Filename like ''%.z7%''
or Filename like ''%.z8%''
or Filename like ''%.z9%''
)
order by Directory,Filename asc;');


Insert into Queries (Query_Name, Query_SQL_Text) Values ('Show [Animation] Video Only', 'select Files.ID, IFNULL(Corrections_Files.Corrected_Name, Files.Filename) as Filename, IFNULL(Corrections_Directory.Corrected_Directory, Files.Directory) as Directory, printf("%,d",Size) as Size, Date, Volume, Files.Watched, Series.Name as IMDB_Series_Name, Episode_ID from Files 
left join Corrections_Files on files.id = Corrections_Files.Match_ID 
left join Corrections_Directory on files.id = Corrections_Directory.Match_ID 
left join Series on Series.ID = Files.Series_ID
inner join Volumes on Files.Volume_ID = Volumes.ID
Where(
Filename like ''%.mkv''
or Filename like ''%.mp4''
or Filename like ''%.mov''
or Filename like ''%.wmv''
or Filename like ''%.avi''
or Filename like ''%.flv''
or Filename like ''%.mpg''
or Filename like ''%.mpe''
or Filename like ''%.mpeg''
or Filename like ''%.3gpp''
or Filename like ''%.asf''
or Filename like ''%.asx''
or Filename like ''%.avs''
or Filename like ''%.divx''
or Filename like ''%.m2t''
or Filename like ''%.m2ts''
or Filename like ''%.m4v''
or Filename like ''%.mts''
or Filename like ''%.ts''
) AND
Volume like ''Anim%''
order by Directory,Filename asc;');


Insert into Queries (Query_Name, Query_SQL_Text) Values ('Show [Animation] Video Only (+zip)', 'select Files.ID, IFNULL(Corrections_Files.Corrected_Name, Files.Filename) as Filename, IFNULL(Corrections_Directory.Corrected_Directory, Files.Directory) as Directory, printf("%,d",Size) as Size, Date, Volume, Files.Watched, Series.Name as IMDB_Series_Name, Episode_ID from Files 
left join Corrections_Files on files.id = Corrections_Files.Match_ID 
left join Corrections_Directory on files.id = Corrections_Directory.Match_ID 
left join Series on Series.ID = Files.Series_ID
inner join Volumes on Files.Volume_ID = Volumes.ID
Where(
Filename like ''%.mkv''
or Filename like ''%.mp4''
or Filename like ''%.mov''
or Filename like ''%.wmv''
or Filename like ''%.avi''
or Filename like ''%.flv''
or Filename like ''%.mpg''
or Filename like ''%.mpe''
or Filename like ''%.mpeg''
or Filename like ''%.3gpp''
or Filename like ''%.asf''
or Filename like ''%.asx''
or Filename like ''%.avs''
or Filename like ''%.divx''
or Filename like ''%.m2t''
or Filename like ''%.m2ts''
or Filename like ''%.m4v''
or Filename like ''%.mts''
or Filename like ''%.ts''
or Filename like ''%.zip''
or Filename like ''%.z0%''
or Filename like ''%.z1%''
or Filename like ''%.z2%''
or Filename like ''%.z3%''
or Filename like ''%.z4%''
or Filename like ''%.z5%''
or Filename like ''%.z6%''
or Filename like ''%.z7%''
or Filename like ''%.z8%''
or Filename like ''%.z9%''
) AND
Volume like ''Anim%''
order by Directory,Filename asc;');


Insert into Queries (Query_Name, Query_SQL_Text) Values ('Show [TV] Video Only', 'select Files.ID, IFNULL(Corrections_Files.Corrected_Name, Files.Filename) as Filename, IFNULL(Corrections_Directory.Corrected_Directory, Files.Directory) as Directory, printf("%,d",Size) as Size, Date, Volume, Files.Watched, Series.Name as IMDB_Series_Name, Episode_ID from Files 
left join Corrections_Files on files.id = Corrections_Files.Match_ID 
left join Corrections_Directory on files.id = Corrections_Directory.Match_ID 
left join Series on Series.ID = Files.Series_ID
inner join Volumes on Files.Volume_ID = Volumes.ID
Where(
Filename like ''%.mkv''
or Filename like ''%.mp4''
or Filename like ''%.vob''
or Filename like ''%.mov''
or Filename like ''%.wmv''
or Filename like ''%.avi''
or Filename like ''%.flv''
or Filename like ''%.mpg''
or Filename like ''%.mpe''
or Filename like ''%.mpeg''
or Filename like ''%.3gpp''
or Filename like ''%.asf''
or Filename like ''%.asx''
or Filename like ''%.avs''
or Filename like ''%.divx''
or Filename like ''%.m2t''
or Filename like ''%.m2ts''
or Filename like ''%.m4v''
or Filename like ''%.mts''
or Filename like ''%.ts''
) AND
Volume like ''TV_%''
order by Directory,Filename asc;');


Insert into Queries (Query_Name, Query_SQL_Text) Values ('Show [TV] Video Only (+Zip)', 'select Files.ID, IFNULL(Corrections_Files.Corrected_Name, Files.Filename) as Filename, IFNULL(Corrections_Directory.Corrected_Directory, Files.Directory) as Directory, printf("%,d",Size) as Size, Date, Volume, Files.Watched, Series.Name as IMDB_Series_Name, Episode_ID from Files 
left join Corrections_Files on files.id = Corrections_Files.Match_ID 
left join Corrections_Directory on files.id = Corrections_Directory.Match_ID 
left join Series on Series.ID = Files.Series_ID
inner join Volumes on Files.Volume_ID = Volumes.ID
Where(
Filename like ''%.mkv''
or Filename like ''%.mp4''
or Filename like ''%.vob''
or Filename like ''%.mov''
or Filename like ''%.wmv''
or Filename like ''%.avi''
or Filename like ''%.flv''
or Filename like ''%.mpg''
or Filename like ''%.mpe''
or Filename like ''%.mpeg''
or Filename like ''%.3gpp''
or Filename like ''%.asf''
or Filename like ''%.asx''
or Filename like ''%.avs''
or Filename like ''%.divx''
or Filename like ''%.m2t''
or Filename like ''%.m2ts''
or Filename like ''%.m4v''
or Filename like ''%.mts''
or Filename like ''%.ts''
or Filename like ''%.zip''
or Filename like ''%.z0%''
or Filename like ''%.z1%''
or Filename like ''%.z2%''
or Filename like ''%.z3%''
or Filename like ''%.z4%''
or Filename like ''%.z5%''
or Filename like ''%.z6%''
or Filename like ''%.z7%''
or Filename like ''%.z8%''
or Filename like ''%.z9%''
) AND
Volume like ''TV_%''
order by Directory,Filename asc;');


Insert into Queries (Query_Name, Query_SQL_Text) Values ('Show [TV+Animation] Video Only', 'select Files.ID, IFNULL(Corrections_Files.Corrected_Name, Files.Filename) as Filename, IFNULL(Corrections_Directory.Corrected_Directory, Files.Directory) as Directory, printf("%,d",Size) as Size, Date, Volume, Files.Watched, Series.Name as IMDB_Series_Name, Episode_ID from Files 
left join Corrections_Files on files.id = Corrections_Files.Match_ID 
left join Corrections_Directory on files.id = Corrections_Directory.Match_ID 
left join Series on Series.ID = Files.Series_ID
inner join Volumes on Files.Volume_ID = Volumes.ID
Where(
Filename like ''%.mkv''
or Filename like ''%.mp4''
or Filename like ''%.vob''
or Filename like ''%.mov''
or Filename like ''%.wmv''
or Filename like ''%.avi''
or Filename like ''%.flv''
or Filename like ''%.mpg''
or Filename like ''%.mpe''
or Filename like ''%.mpeg''
or Filename like ''%.3gpp''
or Filename like ''%.asf''
or Filename like ''%.asx''
or Filename like ''%.avs''
or Filename like ''%.divx''
or Filename like ''%.m2t''
or Filename like ''%.m2ts''
or Filename like ''%.m4v''
or Filename like ''%.mts''
or Filename like ''%.ts''
) AND (
Volume like ''TV_%'' OR VOLUME like ''ANIM_%%'')
-- AND FILENAME LIKE ''FILE%''
order by Directory,Filename asc;');


Insert into Queries (Query_Name, Query_SQL_Text) Values ('Show [TV+Animation] Video Only (+Zip)', 'select Files.ID, IFNULL(Corrections_Files.Corrected_Name, Files.Filename) as Filename, IFNULL(Corrections_Directory.Corrected_Directory, Files.Directory) as Directory, printf("%,d",Size) as Size, Date, Volume, Files.Watched, Series.Name as IMDB_Series_Name, Episode_ID from Files 
left join Corrections_Files on files.id = Corrections_Files.Match_ID 
left join Corrections_Directory on files.id = Corrections_Directory.Match_ID 
left join Series on Series.ID = Files.Series_ID
inner join Volumes on Files.Volume_ID = Volumes.ID
Where(
Filename like ''%.mkv''
or Filename like ''%.mp4''
or Filename like ''%.vob''
or Filename like ''%.mov''
or Filename like ''%.wmv''
or Filename like ''%.avi''
or Filename like ''%.flv''
or Filename like ''%.mpg''
or Filename like ''%.mpe''
or Filename like ''%.mpeg''
or Filename like ''%.3gpp''
or Filename like ''%.asf''
or Filename like ''%.asx''
or Filename like ''%.avs''
or Filename like ''%.divx''
or Filename like ''%.m2t''
or Filename like ''%.m2ts''
or Filename like ''%.m4v''
or Filename like ''%.mts''
or Filename like ''%.ts''
or Filename like ''%.zip''
or Filename like ''%.z0%''
or Filename like ''%.z1%''
or Filename like ''%.z2%''
or Filename like ''%.z3%''
or Filename like ''%.z4%''
or Filename like ''%.z5%''
or Filename like ''%.z6%''
or Filename like ''%.z7%''
or Filename like ''%.z8%''
or Filename like ''%.z9%''
) AND (
Volume like ''TV_%'' OR VOLUME like ''ANIM_%%'')
-- AND FILENAME LIKE ''FILE%''
order by Directory,Filename asc;');


Insert into Queries (Query_Name, Query_SQL_Text) Values ('Show [All] Volumes', 'select * from volumes
order by Volume asc;');


Insert into Queries (Query_Name, Query_SQL_Text) Values ('Show [ZZ Misc] File Extensions (Last 4 Chars)', 'SELECT DISTINCT SUBSTR (Filename, -4) AS EXT from Files
order by EXT asc;');
