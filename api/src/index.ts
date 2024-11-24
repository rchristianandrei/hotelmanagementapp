import dotenv from "dotenv";
import express from "express";
import loginRoutes from "./routes/login.routes";
import checkInOutRoutes from "./routes/checkInOut.routes";
import roomsRoutes from "./routes/rooms.routes";

dotenv.config();

const app = express();

const PORT = 3000;

// Middlewares
app.use(express.json());

// Routes
app.use("/api/auth", loginRoutes);
app.use("/api/checkInOut", checkInOutRoutes);
app.use("/api/rooms", roomsRoutes);

app.listen(PORT, () => {
  console.log(`Server running at http://localhost:${PORT}`);
});
