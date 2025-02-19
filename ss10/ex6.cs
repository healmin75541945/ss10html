* {
    box-sizing: border-box;
}

.main {
    background-color: rgb(223, 219, 219);
    margin: 20px;
    width: 800px;
}

.container {
    position: relative;
    width: 800px;
}

.nut button {
    position: absolute;
    top: 20px;
    left: 25px;
    color: white;
    background-color: transparent;
    border: 1px solid white;
    border-radius: 3px;
    padding: 4px;
}

.nd {
    position: absolute;
    bottom: 25px;
    left: 25px;
    color: white;
    width: 500px;
}

.pagination {
    display: flex;
    justify-content: end;
    padding-right: 22px;
}

.pagination {
    display: flex;
    justify-content: flex-end;
    gap: 10px;
    padding: 15px;
}

.pagination button {
    background: #ddd;
    border: none;
    padding: 8px 12px;
    border-radius: 5px;
    transition: 0.3s ease;
}

.pagination button.active {
    border-radius: 50%;
}

.pagination button:hover {
    background: black;
    color: white;
    transform: scale(1.1);
}