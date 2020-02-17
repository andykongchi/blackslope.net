CREATE TABLE public."Movies"
(
    "Id" serial NOT NULL,
    "Title" text NULL,
    "Description" text NULL,
    "ReleaseDate" timestamp NULL,
    CONSTRAINT "PK_Movies" PRIMARY KEY ("Id")
);