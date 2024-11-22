import { Router } from "express";
import { RoomsController } from "../controllers/rooms.controller";

const router: Router = Router();

// #region Create / Update
router.post("/", RoomsController.Save);
// router.put('/:id', RoomsController.updateUser);
// #endregion

// #region Read
router.get("/:keyword", RoomsController.Get1000);
router.get("/", RoomsController.Get1000);
// router.get('/:id', RoomsController.getUserById);
// #endregion

// #region Delete
router.delete("/:id", RoomsController.Delete);
// #endregion

export default router;
