import dotenv from "dotenv";
import express from "express";
import loginRoutes from "./features/login/login.routes";
import checkInOutRoutes from "./features/checkInOut/checkInOut.routes";
import roomsRoutes from "./features/rooms/rooms.routes";
import usersRoutes from "./features/users/users.routes";

dotenv.config();

const app = express();

const PORT = 3000;

// Middlewares
app.use(express.json());

// Routes
app.use("/api/auth", loginRoutes);
app.use("/api/checkInOut", checkInOutRoutes);
app.use("/api/rooms", roomsRoutes);
app.use("/api/users", usersRoutes);

app.listen(PORT, () => {
  console.log(`Server running at http://localhost:${PORT}`);
});
