use load_CSV
GO

bulk insert	dbo.Test_Table
from 'A:\project\DB_interactions\LAST.csv'
with
(fieldterminator = ';',
rowterminator = '\n',
firstrow = 2,
CHECK_CONSTRAINTS,
KEEPNULLS)
