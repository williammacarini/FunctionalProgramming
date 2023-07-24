module ValueClient

type Cliente = {
    Id: int
    Name: string
    LastName: string
}

let clients =
    [
        {
            Id = 1
            Name = "Eu"
            LastName = "Tu"
        };
        {
            Id = 2
            Name = "Tu"
            LastName = "Eu"
        }
    ]

let getData() = clients;
