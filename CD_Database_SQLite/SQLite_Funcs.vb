Imports System.Data.SQLite

Public Class SQLite_Funcs
    Private P_DatabaseName As String = "database.sqlite"
    Private P_ExtraConnectionProperties As String = "Version=3;"
    Private P_Text_VolumeInDrive As String = "Volume in drive"
    Private P_Text_VolumeInDrive_Select_Criteria As String = " is "
    Private P_Text_VolumeSerialNumber As String = "Volume Serial Number"
    Private P_Text_VolumeSerialNumber_Select_Criteria As String = " is "
    Private P_Text_DirectoryOf As String = "Directory of"
    Private P_Text_DirectoryOf_Select_Criteria As String = "Directory of "
    Private P_Text_DirectoryInDirectory As String = "<DIR>"
    Private P_Text_DirectoryJunction As String = "<JUNCTION>"
    Private P_Text_DirectorySymLink As String = "<SYMLINKD>"
    Private P_Text_FileSymLink As String = "<SYMLINK>"
    Private P_Text_Files As String = "File(s)"
    Private P_Text_DateFormat As String = "dd/MM/yyyy"
    Private P_Text_TimeFormat As String = "HH:mm"
    Private P_Text_FileSizeSeparator As String = ","
    Private P_Text_TotalFilesListed As String = "Total Files Listed"
    Private P_Text_TotalDirs As String = " Dir(s)"
    Private P_DatabaseInMemory As Boolean = False

    Public Property GetDatabaseString(ByVal InMemory As Boolean) As String
        Get
            Dim str As New SQLiteConnectionStringBuilder
            If InMemory = False Then
                str.DataSource = DatabaseName
                str.ReadOnly = False
                str.SyncMode = SynchronizationModes.Normal
                str.Version = 3
                str.JournalMode = SQLiteJournalModeEnum.Memory
                Return str.ConnectionString
            Else
                Return "Data Source=InMemorySample;Mode=Memory;Cache=Shared"
            End If
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property DataBaseInMemory As Boolean
        Get
            Return P_DatabaseInMemory
        End Get
        Set(ByVal value As Boolean)
            P_DatabaseInMemory = value
        End Set
    End Property

    Public Property DatabaseName() As String
        Get
            If DataBaseInMemory = True Then
                Return "Memory"
            Else
                Return P_DatabaseName
            End If

        End Get
        Set(ByVal value As String)
            P_DatabaseName = value
        End Set
    End Property

    Public Property ExtraConnectionProperties(ByVal inMemory As Boolean) As String
        Get
            If inMemory = False Then
                Return P_ExtraConnectionProperties
            Else
                Return "Mode=Memory;Cache=Shared;" + P_ExtraConnectionProperties
            End If
        End Get
        Set(ByVal value As String)
            P_ExtraConnectionProperties = value
        End Set
    End Property

    Public Function GetSQLQueryByName(ByVal QueryName As String, ByVal InMemory As Boolean) As String
        Try
            Dim sqlite_conn As New SQLiteConnection
            ' create a new database connection:
            sqlite_conn = New SQLiteConnection(GetDatabaseString(InMemory))

            sqlite_conn.Open()

            Dim sqlite_cmd As SQLiteCommand

            sqlite_cmd = sqlite_conn.CreateCommand()

            Dim SQLText As String = "Select Query_SQL_Text From Queries where Query_Name = '" & QueryName & "';"

            ' Let the SQLiteCommand object know our SQL-Query:
            sqlite_cmd.CommandText = SQLText

            Dim reader As SQLiteDataReader = sqlite_cmd.ExecuteReader()

            If reader.HasRows = True Then   'If recordset has records
                reader.Read()   'Get the first record
                GetSQLQueryByName = reader.GetString(0).Trim

            Else
                GetSQLQueryByName = ""
            End If

            reader.Close()

            ' open the connection:
            sqlite_conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
            GetSQLQueryByName = ""
        End Try
    End Function

    Public Function GetSQLQueryIDByName(ByVal QueryName As String, ByVal InMemory As Boolean) As Int64
        Try
            Dim sqlite_conn As New SQLiteConnection
            ' create a new database connection:
            sqlite_conn = New SQLiteConnection(GetDatabaseString(InMemory))

            sqlite_conn.Open()

            Dim sqlite_cmd As SQLiteCommand

            sqlite_cmd = sqlite_conn.CreateCommand()

            Dim SQLText As String = "Select ID From Queries where Query_Name = '" & QueryName & "';"

            ' Let the SQLiteCommand object know our SQL-Query:
            sqlite_cmd.CommandText = SQLText

            Dim reader As SQLiteDataReader = sqlite_cmd.ExecuteReader()

            If reader.HasRows = True Then   'If recordset has records
                reader.Read()   'Get the first record
                GetSQLQueryIDByName = reader.GetInt64(0)

            Else
                GetSQLQueryIDByName = -1
            End If

            reader.Close()

            ' open the connection:
            sqlite_conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
            GetSQLQueryIDByName = -1
        End Try
    End Function

    Public Function UpdateSQLQueryNameByID(ByVal QueryID As Int64, ByVal NewQueryName As String, ByVal InMemory As Boolean) As Boolean
        Try
            Dim sqlite_conn As New SQLiteConnection
            ' create a new database connection:
            sqlite_conn = New SQLiteConnection(GetDatabaseString(InMemory))

            sqlite_conn.Open()

            Dim sqlite_cmd As SQLiteCommand

            sqlite_cmd = sqlite_conn.CreateCommand()

            NewQueryName = NewQueryName.Replace("'", "''")

            Dim SQLText As String = "Update Queries Set Query_Name = '" & NewQueryName & "' Where ID = " & QueryID.ToString & " ;"

            ' Let the SQLiteCommand object know our SQL-Query:
            sqlite_cmd.CommandText = SQLText

            Dim res As Integer = sqlite_cmd.ExecuteNonQuery()

            If res > 0 Then
                UpdateSQLQueryNameByID = True
            Else
                UpdateSQLQueryNameByID = False
            End If
            ' open the connection:
            sqlite_conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
            UpdateSQLQueryNameByID = False
        End Try
    End Function

    Public Function UpdateSQLQueryQueryByID(ByVal QueryID As Int64, ByVal NewQuery As String, ByVal InMemory As Boolean) As Boolean
        Try
            Dim sqlite_conn As New SQLiteConnection
            ' create a new database connection:
            sqlite_conn = New SQLiteConnection(GetDatabaseString(InMemory))

            sqlite_conn.Open()

            Dim sqlite_cmd As SQLiteCommand

            sqlite_cmd = sqlite_conn.CreateCommand()

            NewQuery = NewQuery.Replace("'", "''")

            Dim SQLText As String = "Update Queries Set Query_SQL_Text = '" & NewQuery & "' Where ID = " & QueryID.ToString & " ;"

            ' Let the SQLiteCommand object know our SQL-Query:
            sqlite_cmd.CommandText = SQLText

            Dim res As Integer = sqlite_cmd.ExecuteNonQuery()

            If res > 0 Then
                UpdateSQLQueryQueryByID = True
            Else
                UpdateSQLQueryQueryByID = False
            End If
            ' open the connection:
            sqlite_conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
            UpdateSQLQueryQueryByID = False
        End Try
    End Function

    Public Function DeleteSQLQueryByID(ByVal QueryID As Int64, ByVal InMemory As Boolean) As Boolean
        Try
            Dim sqlite_conn As New SQLiteConnection
            ' create a new database connection:
            sqlite_conn = New SQLiteConnection(GetDatabaseString(InMemory))

            sqlite_conn.Open()

            Dim sqlite_cmd As SQLiteCommand

            sqlite_cmd = sqlite_conn.CreateCommand()

            Dim SQLText As String = "Delete from Queries Where ID = " & QueryID.ToString & " ;"

            ' Let the SQLiteCommand object know our SQL-Query:
            sqlite_cmd.CommandText = SQLText

            Dim res As Integer = sqlite_cmd.ExecuteNonQuery()

            If res > 0 Then
                DeleteSQLQueryByID = True
            Else
                DeleteSQLQueryByID = False
            End If
            ' open the connection:
            sqlite_conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
            DeleteSQLQueryByID = False
        End Try
    End Function

    Public Function AddNewSQLQuery(ByVal QueryName As String, ByVal QueryText As String, ByVal InMemory As Boolean) As Boolean
        Try
            Dim sqlite_conn As New SQLiteConnection
            ' create a new database connection:
            sqlite_conn = New SQLiteConnection(GetDatabaseString(InMemory))

            sqlite_conn.Open()

            Dim sqlite_cmd As SQLiteCommand

            sqlite_cmd = sqlite_conn.CreateCommand()

            QueryName = QueryName.Replace("'", "''")
            QueryText = QueryText.Replace("'", "''")

            Dim SQLText As String = "INSERT INTO Queries (Query_Name, Query_SQL_Text) VALUES ('" & QueryName & "', '" & QueryText & "');"

            ' Let the SQLiteCommand object know our SQL-Query:
            sqlite_cmd.CommandText = SQLText

            Dim res As Integer = sqlite_cmd.ExecuteNonQuery()

            If res > 0 Then
                AddNewSQLQuery = True
            Else
                AddNewSQLQuery = False
            End If
            ' open the connection:
            sqlite_conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
            AddNewSQLQuery = False
        End Try
    End Function

    Public Function FillInListBox(ByVal SQLText As String, ByRef LB As ListBox, ByVal InMemory As Boolean) As Boolean
        Try
            Dim sqlite_conn As New SQLiteConnection
            ' create a new database connection:
            sqlite_conn = New SQLiteConnection(GetDatabaseString(InMemory))

            sqlite_conn.Open()

            Dim ds As New DataSet
            Dim da As New SQLiteDataAdapter(SQLText, sqlite_conn)
            da.Fill(ds)

            LB.DataSource = ds.Tables(0).DefaultView

            LB.DisplayMember = ds.Tables(0).Columns(0).ColumnName

            FillInListBox = True
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
            FillInListBox = False
        End Try
    End Function

    Public Function FillInDataGridView(ByVal SQLText As String, ByRef DataGrid As DataGridView, ByVal InMemory As Boolean) As Boolean
        Try
            Dim sqlite_conn As New SQLiteConnection
            ' create a new database connection:
            sqlite_conn = New SQLiteConnection(GetDatabaseString(InMemory))

            sqlite_conn.Open()

            Dim ds As New DataSet
            Dim da As New SQLiteDataAdapter(SQLText, sqlite_conn)
            da.Fill(ds)

            DataGrid.DataSource = ds.Tables(0).DefaultView

            FillInDataGridView = True
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
            FillInDataGridView = False
        End Try
    End Function

    Public Function SaveDatabaseInMemoryToDisk() As Boolean
        Try
            ' create a new database connection:

            DataBaseInMemory = True

            Dim sqlite_memory = New SQLiteConnection(GetDatabaseString(True))
            sqlite_memory.Open()

            DataBaseInMemory = False

            Dim sqlite_conn_disk = New SQLiteConnection(GetDatabaseString(False))
            sqlite_conn_disk.Open()

            sqlite_memory.BackupDatabase(sqlite_conn_disk, "main", "main", -1, Nothing, 0)
            SaveDatabaseInMemoryToDisk = True

            sqlite_memory.Close()
            sqlite_conn_disk.Close()

            DataBaseInMemory = True

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
            SaveDatabaseInMemoryToDisk = False
        End Try
    End Function

    Public Function ReadDatabaseFromDisktoMemory() As Boolean
        Try
            ' create a new database connection:

            'Dim sqlite_conn = New SQLiteConnection("Data Source=" + DatabaseName + ";" + ExtraConnectionProperties(True))
            Dim sqlite_conn = New SQLiteConnection(GetDatabaseString(True))
            sqlite_conn.Open()

            Dim sqlite_conn_disk = New SQLiteConnection(GetDatabaseString(False))
            sqlite_conn_disk.Open()

            sqlite_conn_disk.BackupDatabase(sqlite_conn, "main", "main", -1, Nothing, -1)

            sqlite_conn.Close()
            sqlite_conn_disk.Close()

            ReadDatabaseFromDisktoMemory = True

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
            ReadDatabaseFromDisktoMemory = False
        End Try
    End Function

    ''' <summary>
    ''' Create System Database, tables and indexes
    ''' </summary>
    ''' <returns></returns>
    Public Function CreateDatabase() As Boolean
        Try
            Dim sqlite_conn As SQLiteConnection
            Dim sqlite_cmd As SQLiteCommand

            ' create a new database connection:
            sqlite_conn = New SQLiteConnection(GetDatabaseString(DataBaseInMemory))

            ' open the connection:
            sqlite_conn.Open()

            sqlite_cmd = sqlite_conn.CreateCommand()

            ' Let the SQLiteCommand object know our SQL-Query:
            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS [Volumes] ([ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                                                                            [Serial_Number] NVARCHAR(6) NOT NULL,
                                                                            [Volume] NVARCHAR(128) NOT NULL, 
                                                                            [Volume_DisplayName] NVARCHAR(2048) NULL, 
                                                                            [Volume_FileName] NVARCHAR(2048) NOT NULL,
                                                                            [Type] INTEGER NULL)"

            ' Now lets execute the SQL ;-)
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Serial_Number ON Volumes (Serial_Number)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE UNIQUE INDEX IF NOT EXISTS Serial_Number_Volume ON Volumes (Serial_Number,Volume)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE UNIQUE INDEX IF NOT EXISTS Volume_Serial_Number ON Volumes (Volume,Serial_Number)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Volume ON Volumes (Volume)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Volume_FileName ON Volumes (Volume_FileName)"
            sqlite_cmd.ExecuteNonQuery()


            ' Let the SQLiteCommand object know our SQL-Query:
            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS [Files] ([ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                                                                            [Volume_ID] INTEGER NOT NULL, 
                                                                            [Filename] NVARCHAR(1024) NOT NULL,
                                                                            [Directory] NVARCHAR(1024) NOT NULL,
                                                                            [Date] CHARACTER(23) NULL, 
                                                                            [Series_ID] Integer NULL, 
                                                                            [Episode_ID] NVARCHAR(20) NULL, 
                                                                            [Season] Integer NULL, 
                                                                            [Size] Integer NOT NULL, 
                                                                            [Watched] integer NULL)"


            ' Now lets execute the SQL ;-)
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Volume_ID ON Files (Volume_ID)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Filename ON Files (Filename)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Directory ON Files (Directory)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Date ON Files (Date)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Series_ID ON Files (Series_ID)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Episode_ID ON Files (Episode_ID)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Season ON Files (Season)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Size ON Files (Size)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Watched ON Files (Watched)"
            sqlite_cmd.ExecuteNonQuery()



            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS [Series] ([ID] integer NOT NULL PRIMARY KEY AUTOINCREMENT, 
                                                                            [Name] NVARCHAR(1024) NOT NULL, 
                                                                            [Year] integer NOT NULL, 
                                                                            [SeasonCount] Integer NULL,                                                                             
                                                                            [EpisodeCount] Integer NULL,
                                                                            [SpecialsCount] Integer NULL, 
                                                                            [IMDB_ID] NVARCHAR(20) NULL,
                                                                            [IMDB_URL] NVARCHAR(100) NULL,
                                                                            [TheTVDB_ID] NVARCHAR(20) NULL, 
                                                                            [TheTVDB_URL] NVARCHAR(100) NULL, 
                                                                            [Site3_ID] NVARCHAR(20) NULL, 
                                                                            [Site3_URL] NVARCHAR(100) NULL, 
                                                                            [Site4_ID] NVARCHAR(20) NULL, 
                                                                            [Site4_URL] NVARCHAR(100) NULL, 
                                                                            [Site5_ID] NVARCHAR(20) NULL, 
                                                                            [Site5_URL] NVARCHAR(100) NULL,
                                                                            [IsMovie] Integer NULL,
                                                                            [Watched] Integer NULL,
                                                                            [Ended] Integer NULL, 
                                                                            [Premiered_Date] CHARACTER(23) NULL, 
                                                                            [Complete] Integer NULL)"

            ' Now lets execute the SQL ;-)
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Name ON Series (Name)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Year ON Series (Year)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Name_Year ON Series (Name,Year)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Year_Name ON Series (Year,Name)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS SeasonCount ON Series (SeasonCount)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS EpisodeCount ON Series (EpisodeCount)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS SpecialsCount ON Series (SpecialsCount)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS IMDB_ID ON Series (IMDB_ID)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS TheTVDB_ID ON Series (TheTVDB_ID)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Watched ON Series (Watched)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Ended ON Series (Ended)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Premiered_Date ON Series (Premiered_Date)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Complete ON Series (Complete)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS Premiered_Date_Name ON Series (Premiered_Date,Name)"
            sqlite_cmd.ExecuteNonQuery()

            sqlite_cmd.CommandText = "CREATE INDEX IF NOT EXISTS IsMovie ON Series (IsMovie)"
            sqlite_cmd.ExecuteNonQuery()


            'Correction Type: Filename
            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS [Corrections_Files] ([ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                                                                            [Match_ID] INTEGER NOT NULL, 
                                                                            [Corrected_Name] NVARCHAR(1024) NOT NULL
                                                                            )"

            ' Now lets execute the SQL ;-)
            sqlite_cmd.ExecuteNonQuery()


            'Correction Type: Directory
            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS [Corrections_Directory] ([ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                                                                            [Match_ID] INTEGER NOT NULL, 
                                                                            [Corrected_Directory] NVARCHAR(1024) NOT NULL
                                                                            )"

            ' Now lets execute the SQL ;-)
            sqlite_cmd.ExecuteNonQuery()

            'Store SQL Queries
            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS [Queries] ([ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                                                                            [Query_Name] NVARCHAR(1024) NOT NULL,
                                                                            [Query_SQL_Text] NVARCHAR(8192) NOT NULL
                                                                            )"

            ' Now lets execute the SQL ;-)
            sqlite_cmd.ExecuteNonQuery()

            ' close the connection:
            sqlite_conn.Close()

            CreateDatabase = True

        Catch
            CreateDatabase = False
        End Try
    End Function

    Public Function CheckExists_Volume(ByVal Volume As String, ByVal Serial As String, ByVal CheckBoth As Boolean, ByVal CheckCorrectedVolume As Boolean) As Integer
        Try
            Dim sqlite_conn As SQLiteConnection
            Dim sqlite_cmd As SQLiteCommand

            ' create a new database connection:
            sqlite_conn = New SQLiteConnection(GetDatabaseString(DataBaseInMemory))

            ' open the connection:
            sqlite_conn.Open()

            sqlite_cmd = sqlite_conn.CreateCommand()

            Dim VoltoCheck As String = "Volume"
            If CheckCorrectedVolume = True Then

            End If

            ' Let the SQLiteCommand object know our SQL-Query:
            sqlite_cmd.CommandText = "Select Volume, Serial_Number from Volumes where " & VoltoCheck & "='" & Volume & "' and Serial_Number='" & Serial & "'"

            ' Now lets execute the SQL ;-)
            Dim reader As SQLiteDataReader = sqlite_cmd.ExecuteReader()

            If reader.HasRows = True Then   'If recordset has records
                reader.Read()   'Get the first record
                If CheckBoth = True Then
                    If ((reader.GetString(0).Trim.ToUpper = Volume.Trim.ToUpper) And (reader.GetString(1).Trim.ToUpper = Serial.Trim.ToUpper)) Then
                        CheckExists_Volume = 0
                    Else
                        CheckExists_Volume = 1
                    End If
                Else
                    If ((reader.GetString(0).Trim.ToUpper = Volume.Trim.ToUpper)) Then
                        CheckExists_Volume = 0
                    Else
                        CheckExists_Volume = 1
                    End If
                End If
                reader.Close()
            Else
                CheckExists_Volume = 2
            End If
            ' open the connection:
            sqlite_conn.Close()
        Catch
            CheckExists_Volume = 4
        End Try
    End Function

    Public Function GetID_Volume(ByVal Volume As String, ByVal Serial As String) As Int64
        Try
            Dim sqlite_conn As SQLiteConnection
            Dim sqlite_cmd As SQLiteCommand

            ' create a new database connection:
            sqlite_conn = New SQLiteConnection(GetDatabaseString(DataBaseInMemory))

            ' open the connection:
            sqlite_conn.Open()

            sqlite_cmd = sqlite_conn.CreateCommand()

            ' Let the SQLiteCommand object know our SQL-Query:
            sqlite_cmd.CommandText = "Select ID from Volumes where Volume='" & Volume & "' and Serial_Number='" & Serial & "'"

            ' Now lets execute the SQL ;-)
            Dim reader As SQLiteDataReader = sqlite_cmd.ExecuteReader()

            If reader.HasRows = True Then
                reader.Read()
                Dim res As Int64 = reader.GetInt64(0)
                reader.Close()
                GetID_Volume = res
            Else
                GetID_Volume = -1
            End If

            ' open the connection:
            sqlite_conn.Close()
        Catch
            GetID_Volume = -2

        End Try
    End Function

    ''' <summary>
    ''' Add New Volume to the Database.
    ''' </summary>
    ''' <returns>Returns a minus for an error, else positive for the Volume ID</returns>
    Public Function Add_Volume(ByVal Volume As String, ByVal Serial As String, ByVal FileName As String) As Integer
        Try
            Dim sqlite_conn As SQLiteConnection
            Dim sqlite_cmd As SQLiteCommand

            ' create a new database connection:
            sqlite_conn = New SQLiteConnection(GetDatabaseString(DataBaseInMemory))

            ' open the connection:
            sqlite_conn.Open()

            sqlite_cmd = sqlite_conn.CreateCommand()

            ' Let the SQLiteCommand object know our SQL-Query:
            sqlite_cmd.CommandText = "INSERT INTO Volumes (Volume, Serial_Number, Volume_FileName) VALUES ('" & Volume & "', '" & Serial & "', '" & FileName & "')"

            ' Now lets execute the SQL ;-)
            sqlite_cmd.ExecuteNonQuery()

            ' open the connection:
            sqlite_conn.Close()
            Add_Volume = 0
        Catch ex As Exception
            Add_Volume = 1
        End Try
    End Function

    Public Function CheckExists_Series() As Integer


    End Function

    ''' <summary>
    ''' Parses a text file from a DIR command, and writes the serial no and volume into the Volume table, and each file into the Files table.
    ''' </summary>
    ''' <param name="VolumeID">Int64, the ID of the disk volume in the volumes table.</param>
    ''' <param name="FileName">String, Filename</param>
    ''' <param name="Directory">String, Directory the file is stored in</param>
    ''' <param name="FDate">DateTime, the date and time stamp of the file</param>
    ''' <param name="FSize">Int64, size of the file</param>
    ''' <returns>0 for true, 1 for error</returns>
    Public Function Add_File_ToDatabase(ByVal VolumeID As Int64, ByVal FileName As String, ByVal Directory As String, ByVal FDate As DateTime, ByVal FSize As Int64) As Integer
        Try
            Dim sqlite_conn As SQLiteConnection
            Dim sqlite_cmd As SQLiteCommand

            ' create a new database connection:
            sqlite_conn = New SQLiteConnection(GetDatabaseString(DataBaseInMemory))

            ' open the connection:
            sqlite_conn.Open()

            sqlite_cmd = sqlite_conn.CreateCommand()

            'Clean input fields
            FileName = FileName.Replace("'", "''")
            Directory = Directory.Replace("'", "''")

            ' Let the SQLiteCommand object know our SQL-Query:
            sqlite_cmd.CommandText = "INSERT INTO Files (Volume_ID, Filename, Directory, Date, Size) VALUES (" & CStr(VolumeID) & ", '" & FileName & "', '" & Directory & "', '" & FDate.ToString("yyyy-MM-dd HH:mm") & "', " & CStr(FSize) & ")"

            ' Now lets execute the SQL ;-)
            sqlite_cmd.ExecuteNonQuery()

            ' open the connection:
            sqlite_conn.Close()
            Add_File_ToDatabase = 0
        Catch ex As Exception
            Console.WriteLine("Error: {0}", ex.ToString())
            Add_File_ToDatabase = 1
        End Try
    End Function

    Public Function Add_Series_ToDatabase() As Integer

    End Function

    Public Function AddCorrectedFileorFolderToDatabase(ByVal LineID As Integer, ByVal NewName As String, ByVal IsFolder As Boolean) As Integer
        Try
            Dim sqlite_conn As SQLiteConnection
            Dim sqlite_cmd As SQLiteCommand

            ' create a new database connection:
            sqlite_conn = New SQLiteConnection(GetDatabaseString(DataBaseInMemory))

            ' open the connection:
            sqlite_conn.Open()

            sqlite_cmd = sqlite_conn.CreateCommand()

            'Clean input fields
            NewName = NewName.Replace("'", "''")

            If IsFolder = True Then
                sqlite_cmd.CommandText = "INSERT INTO Corrections_Directory (Match_ID, Corrected_Directory) VALUES (" & CStr(LineID) & ", '" & NewName & "')"
            Else
                sqlite_cmd.CommandText = "INSERT INTO Corrections_Files (Match_ID, Corrected_Name) VALUES (" & CStr(LineID) & ", '" & NewName & "')"
            End If

            ' Now lets execute the SQL ;-)
            sqlite_cmd.ExecuteNonQuery()

            ' open the connection:
            sqlite_conn.Close()
            AddCorrectedFileorFolderToDatabase = 0
        Catch ex As Exception
            Console.WriteLine("Error: {0}", ex.ToString())
            AddCorrectedFileorFolderToDatabase = 1
        End Try
    End Function

    ''' <summary>
    ''' Function to Import an MS-DOS DIR command, saved to a text file.
    ''' </summary>
    ''' <param name="FileToImport">Path to the text file to import</param>
    ''' <returns>True if file imported with no errors.</returns>
    Public Function ImportDIRFile(ByVal FileToImport As String, ByVal RemoveDirectoryFileLetter As Boolean) As Integer
        If FileIO.FileSystem.FileExists(DatabaseName) Then
            If FileIO.FileSystem.FileExists(FileToImport) Then
                Dim Volume As String = ""
                Dim Serial As String = ""
                Dim VolumeID As Int64 = 0
                Dim CurrentFile As String = ""
                Dim CurrentFileSize As String = ""
                Dim CurrentFileDate As String = ""
                Dim CurrentFileTime As String = ""
                Dim CurrentFileDate_real As Date = Now
                Dim CurrentDirectory As String = ""

                Dim StreamReader As New IO.StreamReader(FileToImport)

                Dim temp As String

                Dim lineCount = IO.File.ReadAllLines(FileToImport).Length
                frmImports.pbSingleFile.Value = 0
                frmImports.pbSingleFile.Maximum = lineCount

                Do While Not StreamReader.EndOfStream
                    temp = StreamReader.ReadLine
                    temp = temp.Trim

                    frmImports.pbSingleFile.PerformStep()

                    Select Case True
                        Case temp.Contains(P_Text_VolumeInDrive)
                            ' Deal with Volume Info
                            Volume = temp.Substring(temp.IndexOf(P_Text_VolumeInDrive_Select_Criteria) + P_Text_VolumeInDrive_Select_Criteria.Length)
                            Exit Select

                        Case temp.Contains(P_Text_VolumeSerialNumber)
                            ' Deal with Vol Serial Number
                            Serial = temp.Substring(temp.IndexOf(P_Text_VolumeSerialNumber_Select_Criteria) + P_Text_VolumeSerialNumber_Select_Criteria.Length)
                            If CheckExists_Volume(Volume, Serial, True, False) = 0 Then
                                ' Get Volume ID
                                VolumeID = GetID_Volume(Volume, Serial)
                            Else
                                'Add New Volume
                                Add_Volume(Volume, Serial, FileToImport)
                                'get volume ID
                                VolumeID = GetID_Volume(Volume, Serial)
                            End If
                            Exit Select

                        Case temp = ""
                            'Line is blank (ignore)
                            Exit Select

                        Case temp.Contains(P_Text_DirectoryOf)
                            'Set Directory
                            CurrentDirectory = temp.Substring(temp.IndexOf(P_Text_DirectoryOf_Select_Criteria) + P_Text_DirectoryOf_Select_Criteria.Length)
                            If RemoveDirectoryFileLetter = True Then 'Remove the Drive Letter, and Colon, from the Directory
                                CurrentDirectory = CurrentDirectory.Substring(3)
                            End If
                            Exit Select

                        Case temp.Contains(P_Text_DirectoryInDirectory)
                            'Line is a folder, within the current folder (ignore)
                            Exit Select

                        Case temp.Contains(P_Text_DirectoryJunction)
                            'Line is a directory Junction (ignore)
                            Exit Select

                        Case temp.Contains(P_Text_DirectorySymLink)
                            'Line is a directory symlink (ignore)
                            Exit Select

                        Case temp.Contains(P_Text_FileSymLink)
                            'line is a file symlink (ignore)
                            Exit Select

                        Case temp.Contains(P_Text_Files)
                            'Line with no of files in Dir (ignore)
                            Exit Select

                        Case temp.Contains(P_Text_TotalFilesListed)
                            'Line is last lines: Total files listed:
                            Exit Select

                        Case temp.Contains(P_Text_TotalDirs)
                            'Line is last lines: x Dir(s) x bytes free

                        Case Else
                            'Line is a normal file, with date, time, size and filename

                            'Copy everything up to the first space, into the text date variable
                            CurrentFileDate = temp.Substring(0, temp.IndexOf(" ") + 1).Trim

                            'convert the text date variable, into a proper date time (just the date part though)
                            If DateTime.TryParseExact(CurrentFileDate, P_Text_DateFormat, Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, CurrentFileDate_real) Then
                                'the parse worked and the dateValue variable now holds the datetime that was parsed as it is passing in ByRef
                            Else
                                'the parse failed
                            End If
                            'CurrentFileDate_real = DateTime.ParseExact(CurrentFileDate, P_Text_DateFormat, System.Globalization.DateTimeFormatInfo.InvariantInfo)

                            'remove everything up to the first space, from the current text line
                            temp = temp.Substring(temp.IndexOf(" ") + 1).Trim

                            'Copy everything up to the first space, into the text time variable
                            CurrentFileTime = temp.Substring(0, temp.IndexOf(" ") + 1).Trim

                            'convert the text time variable, into a proper date time (just the time part though) and add the time to the datetime variable
                            Dim TempTime As DateTime
                            If DateTime.TryParseExact(CurrentFileTime, P_Text_TimeFormat, Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, TempTime) Then
                                'the parse worked and the dateValue variable now holds the datetime that was parsed as it is passing in ByRef
                            Else
                                'the parse failed
                            End If
                            CurrentFileDate_real = CurrentFileDate_real.AddHours(TempTime.Hour)
                            CurrentFileDate_real = CurrentFileDate_real.AddMinutes(TempTime.Minute)
                            'CurrentFileDate_real += DateTime.ParseExact(CurrentFileTime, P_Text_TimeFormat, System.Globalization.DateTimeFormatInfo.InvariantInfo, Globalization.DateTimeStyles.None)

                            'remove everything up to the first space, from the current text line
                            temp = temp.Substring(temp.IndexOf(" ") + 1).Trim

                            'Copy from first char, to the first space, into the file size variable
                            CurrentFileSize = temp.Substring(0, temp.IndexOf(" ") + 1).Trim

                            'Remove the comma separators from the file size
                            CurrentFileSize = CurrentFileSize.Replace(P_Text_FileSizeSeparator, "")

                            'remove everything up to the first space, from the current text line
                            temp = temp.Substring(temp.IndexOf(" ") + 1)

                            'Copy the remaining string into the file name
                            CurrentFile = temp.Trim

                            'Actually add each of these parts into the 
                            If Add_File_ToDatabase(VolumeID, CurrentFile, CurrentDirectory, CurrentFileDate_real, Convert.ToInt64(CurrentFileSize)) = 0 Then
                                'added ok!
                            Else
                                'add failed
                            End If

                            Exit Select
                    End Select
                    Application.DoEvents()
                Loop

                ImportDIRFile = 0   'No Problems! Imported Fine!
            Else
                ImportDIRFile = 2   'File didn't exist
            End If
        Else
            ImportDIRFile = 4   'Database didn't exist
            Exit Function
        End If
    End Function

End Class
