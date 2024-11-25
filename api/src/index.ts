import dotenv from "dotenv";
import express from "express";
import mongoose from "mongoose";
import loginRoutes from "./features/login/login.routes";
import checkInOutRoutes from "./features/checkInOut/checkInOut.routes";
import roomsRoutes from "./features/rooms/rooms.routes";
import usersRoutes from "./features/users/users.routes";
import recordsRoutes from "./features/records/records.routes";

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
app.use("/api/records", recordsRoutes);

// Connect to MongoDB
mongoose
  .connect("mongodb://localhost:27017/hotmap")
  .then(() => {
    console.log("Connected to MongoDB");
    app.listen(PORT, () => {
      console.log(`Server running at http://localhost:${PORT}`);
    });
  })
  .catch((err) => console.error("Failed to connect to MongoDB", err));
