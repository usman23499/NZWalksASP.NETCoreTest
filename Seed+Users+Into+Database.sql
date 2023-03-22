--Insert Users
Insert into Users (Id, Username, EmailAddress, Password, FirstName, LastName)
Values ('abb1561a-b9e9-4e1b-b89c-362c14c24ff1', 'readonly@user.com', 'readonly@user.com', 'Readonly@user', 'Read Only', 'User');

Insert into Users (Id, Username, EmailAddress, Password, FirstName, LastName)
Values ('ebad0f8c-aa01-4c06-8467-d5a892fe212f', 'readwrite@user.com', 'readwrite@user.com', 'Readwrite@user', 'Read Write', 'User');

--Insert Roles
Insert into Roles (Id, Name)
Values ('b7717016-1bdf-475d-9916-eb8bb22769d3', 'reader');

Insert into Roles (Id, Name)
Values ('663ec6c3-e369-47e6-87c5-1ccb8b7dfa33', 'writer');


--Insert Users_Roles
Insert into Users_Roles (Id, UserId, RoleId)
Values ('7c2d51cb-c878-49a6-8392-f5ee28bd3602', 'abb1561a-b9e9-4e1b-b89c-362c14c24ff1', 'b7717016-1bdf-475d-9916-eb8bb22769d3');

Insert into Users_Roles (Id, UserId, RoleId)
Values ('13cbebb1-5f80-43c5-a7af-292e05e62956', 'ebad0f8c-aa01-4c06-8467-d5a892fe212f', '663ec6c3-e369-47e6-87c5-1ccb8b7dfa33');

Insert into Users_Roles (Id, UserId, RoleId)
Values ('c1d8925c-aa2f-404e-af23-e5a6f1774c8f', 'ebad0f8c-aa01-4c06-8467-d5a892fe212f', 'b7717016-1bdf-475d-9916-eb8bb22769d3');

