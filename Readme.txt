https://docs.microsoft.com/ko-kr/ef/core/managing-schemas/scaffolding?tabs=vs
https://docs.microsoft.com/ko-kr/ef/core/cli/powershell


-Barunson DB
dotnet ef dbcontext scaffold "Server=barun-shopdb.9925ce92729d.database.windows.net;Database=barunson;User ID=???;Password=???;" Microsoft.EntityFrameworkCore.SqlServer --context-namespace Barunson.DbContext --context BarunsonContext --output-dir DbModels\Barunson --data-annotations --use-database-names --no-pluralize --no-onconfiguring --force

-bar_shop1 db에 datbase table이 있음 시스템 이름과 충돌 발생 함으로 수정 해야 함.
-bar_shop1 DB
dotnet ef dbcontext scaffold "Server=barun-shopdb.9925ce92729d.database.windows.net;Database=bar_shop1;User ID=???;Password=???;" Microsoft.EntityFrameworkCore.SqlServer --context-namespace Barunson.DbContext --context BarShopContext --output-dir DbModels\BarShop --data-annotations --use-database-names --no-pluralize --no-onconfiguring --force

-MO_SVR DB
dotnet ef dbcontext scaffold "Server=barun-shopdb.9925ce92729d.database.windows.net;Database=MO_SVR;User ID=???;Password=???;"  Microsoft.EntityFrameworkCore.SqlServer --context-dir DbContext --context-namespace Barunson.DbContext --context MoSvrContext --output-dir DbModels\MoSvr --data-annotations --use-database-names --no-pluralize --no-onconfiguring --force

-deardeer db
dotnet ef dbcontext scaffold "Server=115.68.229.153;database=wedding;uid=???;pwd=???;" Pomelo.EntityFrameworkCore.MySql --context-dir DbContext --context-namespace Barunson.DbContext --context DearDeerContext --output-dir DbModels\DearDeer --data-annotations --use-database-names --no-pluralize --no-onconfiguring --force

