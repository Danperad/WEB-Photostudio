import React, {useState} from 'react';
import {Box, Button, Modal, Rating, Stack, Typography} from "@mui/material";
import {NewService, Service} from "../models/Models";
import AddServiceModal from "./AddServiceModal";
import {useDispatch, useSelector} from "react-redux";
import {AppDispatch, RootState} from "../redux/store";
import {cartActions} from "../redux/slices/cartSlice";
import Carousel from 'react-material-ui-carousel'

interface ServiceModalProps {
    open: boolean,
    handlerClose: () => void,
    service: Service | null
}

export default function ServiceModal(props: ServiceModalProps) {
    const handlePayModalOpen = () => {
        if (props.service!.serviceType === 1) {
            const service: NewService = {
                id: new Date().getTime() + Math.random(),
                service: props.service!,
                startTime: null,
                duration: null,
                hall: null,
                employee: null,
                address: null,
                rentedItem: null,
                number: null,
                isFullTime: null,
            }
            dispatch(cartActions.ServiceAdded(service));
            props.handlerClose();
            return;
        }
        setOpenPayModal(true);
    };
    const closePayModal = () => {
        setOpenPayModal(false);
    };
    const [openPayModal, setOpenPayModal] = useState(false);
    const [available, setAvailable] = useState<boolean>(false);
    const [key, setKey] = useState<boolean>(false);
    const rootState = useSelector((state: RootState) => state.cart);
    const dispatch = useDispatch<AppDispatch>();

    React.useEffect(() => {
        if (!props.open) {
            setKey(false);
            return;
        }
        if (key) return;
        setKey(true);
        setAvailable(false);
    }, [available, rootState, props, key])
    const style = {
        position: 'absolute' as 'absolute',
        top: '50%',
        left: '50%',
        transform: 'translate(-50%, -50%)',
        width: '60%',
        bgcolor: '#F0EDE8',
        border: '2px solid #776D61',
        borderRadius: '20px',
        boxShadow: 24,
        p: 4,
    };

    if (props.service === null) return <></>;
    return (
        <Modal
            open={props.open}
            onClose={props.handlerClose}
            aria-labelledby="modal-modal-title"
            aria-describedby="modal-modal-description"
        >
            <Box sx={style}>
                <Stack spacing={2} width={"100%"} mt={2} alignItems="center" justifyContent={"center"}>
                    <Stack alignItems="center" justifyContent={"center"}
                           style={{height: "400px", width: "600px", borderRadius: "10px"}}>
                        <Carousel animation={"fade"} indicators={false} sx={{
                            width: "100%",
                            height: "100%"
                        }}>
                            {props.service!.photos.map((photo, index) => (
                                <img
                                    src={photo}
                                    alt={props.service!.title}
                                    key={index}
                                    width="100%"
                                    height="100%"
                                />
                            ))}
                        </Carousel>
                    </Stack>
                    <Box sx={{width: "80%"}}>
                        <Typography variant="subtitle1">
                            ????????????????: {props.service!.title}
                        </Typography>
                        <Typography variant="subtitle1">
                            ????????????????: {props.service!.description}
                        </Typography>
                    </Box>
                    <Stack direction="row" width={"80%"} justifyContent="space-between" alignItems="center">
                        <div style={{width: "100px"}}></div>
                        <Stack direction="row" spacing={2}>
                            <Rating defaultValue={props.service.rating} readOnly precision={0.1}/>
                            <Typography variant="subtitle1">
                                ??????????????????: {props.service!.cost} ????????????
                            </Typography>
                            <Button variant="contained" color="secondary" disabled={available} size="medium"
                                    disableElevation
                                    sx={{borderRadius: '10px'}} onClick={() => handlePayModalOpen()}>
                                ???????????????? ?? ??????????????
                            </Button>
                        </Stack>
                    </Stack>
                </Stack>
                <AddServiceModal open={openPayModal} handlerClose={closePayModal} service={props.service}/>
            </Box>
        </Modal>
    );
}