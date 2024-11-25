import { Router } from "express";
import { verifyToken } from "../../middlewares/verification.middleware";
import { RoomsController } from "./rooms.controller";

const router: Router = Router();

// #region Create / Update
router.post("/", verifyToken, RoomsController.Save);
// router.put('/:id', RoomsController.updateUser);
// #endregion

// #region Read
router.get("/:keyword", verifyToken, RoomsController.Get1000);
router.get("/", verifyToken, RoomsController.Get1000);
router.get("/:id", verifyToken, RoomsController.Get1);
// router.get('/:id', RoomsController.getUserById);
// #endregion

// #region Delete
router.delete("/:id", verifyToken, RoomsController.Delete);
// #endregion

export default router;
